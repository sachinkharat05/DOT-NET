using CIE.Api.Models;

namespace CIE.Api.Services;

public interface IPromptCaptureService
{
    Task<StudentPromptResponse> CapturePromptAsync(CreateStudentPromptRequest request, CancellationToken cancellationToken);

    Task<IReadOnlyList<StudentPromptResponse>> GetAllPromptsAsync(CancellationToken cancellationToken);

    Task<StudentPromptResponse?> GetPromptByIdAsync(int id, CancellationToken cancellationToken);

    Task CheckDatabaseConnectionAsync(CancellationToken cancellationToken);
}
