namespace CIE.Api.Models;

/// <summary>A student prompt saved by the API.</summary>
public sealed record StudentPromptResponse(
    int Id,
    string StudentId,
    string SessionId,
    string PromptText,
    DateTimeOffset CreatedAt);
