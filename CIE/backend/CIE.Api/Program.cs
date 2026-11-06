using CIE.Api.Repositories;
using CIE.Api.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CieDatabase");

if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException(
        "The CIE database connection string is missing. Configure ConnectionStrings:CieDatabase using .NET user-secrets or an environment variable.");
}

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddProblemDetails();
builder.Services.AddScoped<IPromptRepository>(_ =>
    new PromptRepository(connectionString));
builder.Services.AddScoped<IPromptCaptureService, PromptCaptureService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    await using var scope = app.Services.CreateAsyncScope();
    var promptRepository = scope.ServiceProvider.GetRequiredService<IPromptRepository>();
    await promptRepository.InitializeDatabaseAsync(CancellationToken.None);
}

app.UseExceptionHandler();
app.UseStatusCodePages();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
