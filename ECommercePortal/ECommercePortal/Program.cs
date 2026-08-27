var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
//Middleware
app.UseRouting();
//Mapping  static assets and controller routes
app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customers}/{action=Index}/{id?}")
    .WithStaticAssets();
app.Run();