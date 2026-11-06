using CIE.Api.Models;
using CIE.Api.Repositories;

namespace CIE.Api.Services;

public sealed class PromptCaptureService(IPromptRepository promptRepository)
    : IPromptCaptureService
{
    public async Task<StudentPromptResponse> CapturePromptAsync(
        CreateStudentPromptRequest request,
        CancellationToken cancellationToken)
    {
        var prompt = new StudentPrompt
        {
            StudentId = request.StudentId.Trim(),
            SessionId = request.SessionId.Trim(),
            PromptText = request.PromptText.Trim(),
            CreatedAt = DateTime.UtcNow
        };

        var savedPrompt = await promptRepository.AddAsync(prompt, cancellationToken);
        return ToResponse(savedPrompt);
    }

    public async Task<IReadOnlyList<StudentPromptResponse>> GetAllPromptsAsync(
        CancellationToken cancellationToken)
    {
        var prompts = await promptRepository.GetAllAsync(cancellationToken);
        return prompts.Select(ToResponse).ToArray();
    }

    public async Task<StudentPromptResponse?> GetPromptByIdAsync(
        int id,
        CancellationToken cancellationToken)
    {
        var prompt = await promptRepository.GetByIdAsync(id, cancellationToken);
        return prompt is null ? null : ToResponse(prompt);
    }

    public Task CheckDatabaseConnectionAsync(CancellationToken cancellationToken) =>
        promptRepository.CheckConnectionAsync(cancellationToken);

    private static StudentPromptResponse ToResponse(StudentPrompt prompt) =>
        new(
            prompt.Id,
            prompt.StudentId,
            prompt.SessionId,
            prompt.PromptText,
            new DateTimeOffset(DateTime.SpecifyKind(prompt.CreatedAt, DateTimeKind.Utc)));
}
