var builder = WebApplication.CreateBuilder(args); //Web Application builder class
// Service Configuration


builder.Services.AddControllersWithViews();
var app = builder.Build();   //Web Application
//Middleware Configuration
app.UseRouting();
app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();
app.Run();

//dotnew new webapp--------------------Web Applicaiton with only razor pages
//dotnet new mvc-----------------------Web Application with MVC
//dotnet new webapi---------------------Web api minimal code strategy 
//dotnet new webapi --use-controllers---web api using controllers
//      containing layered architecture
//      containing IOC container for DI
//      Middleware for incomming  request , and outgoing responses
