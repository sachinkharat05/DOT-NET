using System.ComponentModel.DataAnnotations;

namespace CIE.Api.Models;

/// <summary>Student prompt content submitted to the API.</summary>
public sealed record CreateStudentPromptRequest
{
    /// <summary>Identifier of the student asking the question.</summary>
    [Required, StringLength(100)]
    public required string StudentId { get; init; }

    /// <summary>Identifier of the learning session.</summary>
    [Required, StringLength(100)]
    public required string SessionId { get; init; }

    /// <summary>Question or prompt text, up to 4,000 characters.</summary>
    [Required, StringLength(4000)]
    public required string PromptText { get; init; }
}
