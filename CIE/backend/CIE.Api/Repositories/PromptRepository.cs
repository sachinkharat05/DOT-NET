using CIE.Api.Models;
using MySqlConnector;

namespace CIE.Api.Repositories;

public sealed class PromptRepository(string connectionString) : IPromptRepository
{
    public async Task InitializeDatabaseAsync(CancellationToken cancellationToken)
    {
        var settings = new MySqlConnectionStringBuilder(connectionString);
        var databaseName = settings.Database;
        if (string.IsNullOrWhiteSpace(databaseName))
        {
            throw new InvalidOperationException(
                "The database name is missing from the CIE connection string.");
        }

        settings.Database = "";
        await using var connection = new MySqlConnection(settings.ConnectionString);
        await connection.OpenAsync(cancellationToken);

        var escapedDatabaseName = databaseName.Replace("`", "``", StringComparison.Ordinal);
        var createDatabaseSql =
            $"CREATE DATABASE IF NOT EXISTS `{escapedDatabaseName}` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;";
        await using (var createDatabase = new MySqlCommand(createDatabaseSql, connection))
        {
            await createDatabase.ExecuteNonQueryAsync(cancellationToken);
        }

        await connection.ChangeDatabaseAsync(databaseName, cancellationToken);

        const string createTableSql = """
            CREATE TABLE IF NOT EXISTS student_prompts (
                id INT AUTO_INCREMENT PRIMARY KEY,
                student_id VARCHAR(100) NOT NULL,
                session_id VARCHAR(100) NOT NULL,
                prompt_text VARCHAR(4000) NOT NULL,
                created_at DATETIME(6) NOT NULL,
                INDEX ix_student_prompts_created_at (created_at),
                INDEX ix_student_prompts_student_session (student_id, session_id)
            );
            """;

        await using var createTable = new MySqlCommand(createTableSql, connection);
        await createTable.ExecuteNonQueryAsync(cancellationToken);
    }

    public async Task<StudentPrompt> AddAsync(
        StudentPrompt prompt,
        CancellationToken cancellationToken)
    {
        const string sql = """
            INSERT INTO student_prompts (student_id, session_id, prompt_text, created_at)
            VALUES (@studentId, @sessionId, @promptText, @createdAt);
            """;

        await using var connection = new MySqlConnection(connectionString);
        await connection.OpenAsync(cancellationToken);
        await using var command = new MySqlCommand(sql, connection);
        command.Parameters.AddWithValue("@studentId", prompt.StudentId);
        command.Parameters.AddWithValue("@sessionId", prompt.SessionId);
        command.Parameters.AddWithValue("@promptText", prompt.PromptText);
        command.Parameters.AddWithValue("@createdAt", prompt.CreatedAt);
        await command.ExecuteNonQueryAsync(cancellationToken);

        prompt.Id = checked((int)command.LastInsertedId);
        return prompt;
    }

    public async Task<IReadOnlyList<StudentPrompt>> GetAllAsync(
        CancellationToken cancellationToken)
    {
        const string sql = """
            SELECT id, student_id, session_id, prompt_text, created_at
            FROM student_prompts
            ORDER BY created_at DESC, id DESC;
            """;

        await using var connection = new MySqlConnection(connectionString);
        await connection.OpenAsync(cancellationToken);
        await using var command = new MySqlCommand(sql, connection);
        await using var reader = await command.ExecuteReaderAsync(cancellationToken);

        var prompts = new List<StudentPrompt>();
        while (await reader.ReadAsync(cancellationToken))
        {
            prompts.Add(MapPrompt(reader));
        }

        return prompts;
    }

    public async Task<StudentPrompt?> GetByIdAsync(
        int id,
        CancellationToken cancellationToken)
    {
        const string sql = """
            SELECT id, student_id, session_id, prompt_text, created_at
            FROM student_prompts
            WHERE id = @id;
            """;

        await using var connection = new MySqlConnection(connectionString);
        await connection.OpenAsync(cancellationToken);
        await using var command = new MySqlCommand(sql, connection);
        command.Parameters.AddWithValue("@id", id);
        await using var reader = await command.ExecuteReaderAsync(cancellationToken);

        return await reader.ReadAsync(cancellationToken) ? MapPrompt(reader) : null;
    }

    public async Task CheckConnectionAsync(CancellationToken cancellationToken)
    {
        await using var connection = new MySqlConnection(connectionString);
        await connection.OpenAsync(cancellationToken);
        await using var command = new MySqlCommand("SELECT 1;", connection);
        await command.ExecuteScalarAsync(cancellationToken);
    }

    private static StudentPrompt MapPrompt(MySqlDataReader reader) =>
        new()
        {
            Id = reader.GetInt32("id"),
            StudentId = reader.GetString("student_id"),
            SessionId = reader.GetString("session_id"),
            PromptText = reader.GetString("prompt_text"),
            CreatedAt = DateTime.SpecifyKind(
                reader.GetDateTime("created_at"),
                DateTimeKind.Utc)
        };
}
