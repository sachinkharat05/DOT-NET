var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();
app.UseRouting();
app.MapStaticAssets();
app.MapRazorPages().WithStaticAssets();
app.Run();

//GUI Application: Views (Presentable User Interface)
//Server Side Pages: aspx.  (Webforms  .net frwrk)
//Server Side Pages: .cshtml(Razor pages)
//View Engine: Razor View Engine
