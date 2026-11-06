namespace CIE.Api.Models;

public sealed class StudentPrompt
{
    public int Id { get; set; }

    public string StudentId { get; set; } = "";

    public string SessionId { get; set; } = "";

    public string PromptText { get; set; } = "";

    public DateTime CreatedAt { get; set; }
}
