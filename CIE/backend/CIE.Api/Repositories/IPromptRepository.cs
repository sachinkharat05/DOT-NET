using CIE.Api.Models;

namespace CIE.Api.Repositories;

public interface IPromptRepository
{
    Task InitializeDatabaseAsync(CancellationToken cancellationToken);

    Task<StudentPrompt> AddAsync(
        StudentPrompt prompt,
        CancellationToken cancellationToken);

    Task<IReadOnlyList<StudentPrompt>> GetAllAsync(
        CancellationToken cancellationToken);

    Task<StudentPrompt?> GetByIdAsync(
        int id,
        CancellationToken cancellationToken);

    Task CheckConnectionAsync(CancellationToken cancellationToken);
}
