using CIE.Api.Models;
using CIE.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CIE.Api.Controllers;

[ApiController]
[Route("api/prompts")]
public sealed class PromptsController(IPromptCaptureService promptService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType<IReadOnlyList<StudentPromptResponse>>(StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<StudentPromptResponse>>> GetAllPrompts(
        CancellationToken cancellationToken)
    {
        var prompts = await promptService.GetAllPromptsAsync(cancellationToken);
        return Ok(prompts);
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType<StudentPromptResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<StudentPromptResponse>> GetPromptById(
        int id,
        CancellationToken cancellationToken)
    {
        var prompt = await promptService.GetPromptByIdAsync(id, cancellationToken);
        return prompt is null ? NotFound() : Ok(prompt);
    }

    [HttpPost]
    [ProducesResponseType<StudentPromptResponse>(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<StudentPromptResponse>> CapturePrompt(
        [FromBody] CreateStudentPromptRequest request,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.StudentId))
        {
            ModelState.AddModelError(nameof(request.StudentId), "Student ID is required.");
        }

        if (string.IsNullOrWhiteSpace(request.SessionId))
        {
            ModelState.AddModelError(nameof(request.SessionId), "Session ID is required.");
        }

        if (string.IsNullOrWhiteSpace(request.PromptText))
        {
            ModelState.AddModelError(nameof(request.PromptText), "Prompt text is required.");
        }

        if (!ModelState.IsValid)
        {
            return ValidationProblem(ModelState);
        }

        var prompt = await promptService.CapturePromptAsync(request, cancellationToken);
        return CreatedAtAction(nameof(GetPromptById), new { id = prompt.Id }, prompt);
    }
}
