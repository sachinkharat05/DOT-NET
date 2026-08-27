var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

//Middleware
app.MapControllers();
app.Run();



//Web API Controller