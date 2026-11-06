using CIE.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CIE.Api.Controllers;

[ApiController]
[Route("api/health")]
public sealed class HealthController(IPromptCaptureService promptService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType<HealthResponse>(StatusCodes.Status200OK)]
    public async Task<ActionResult<HealthResponse>> GetHealth(
        CancellationToken cancellationToken)
    {
        await promptService.CheckDatabaseConnectionAsync(cancellationToken);
        return Ok(new HealthResponse("ok", "mysql"));
    }
}

/// <summary>API and database readiness state.</summary>
public sealed record HealthResponse(string Status, string Database);
