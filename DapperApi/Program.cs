using Dapper;
using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection");

var app = builder.Build();

app.MapGet("/", () => "Transflower API Running");

app.MapGet("/test-db", async () =>
{
    using var connection = new MySqlConnection(connectionString);

    var result = await connection.QuerySingleAsync<int>("SELECT 1");

    return Results.Ok(new
    {
        Message = "Transflower Database Connected Successfully",
        Result = result
    });
});

app.Run();