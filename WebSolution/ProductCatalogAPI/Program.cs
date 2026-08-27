var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();
app.MapGet("/api/customers", () =>{    return "IBM, Microsoft, Oracle";});
app.Run();

//minimal code Strategy Code