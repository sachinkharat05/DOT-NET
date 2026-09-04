var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


//mkdir AspNetCoreDemo              // mkdir AspNetCoreDemo हा command "AspNetCoreDemo" नावाचा नवीन फोल्डर (Directory) तयार करण्यासाठी वापरला जातो
//cd AspNetCoreDemo         // cd AspNetCoreDemo हा command तयार केलेल्या "AspNetCoreDemo" फोल्डरमध्ये जाण्यासाठी वापरला जातो.

//dotnet new sln -n AspNetCoreDemo//हा command "AspNetCoreDemo" नावाची नवीन .NET Solution File (.sln) तयार करतो.

//dotnet new web -n EmptyWebApp // dotnet new web -n EmptyWebApp command is used to create a new ASP.NET Core web application named "EmptyWebApp". This command sets up a basic project structure with minimal files and dependencies, providing a starting point for developers to build their web applications. The generated project includes essential files such as Program.cs, Startup.cs, and configuration files, allowing developers to customize and extend the application according to their requirements.
//dotnet new mvc -n MvcWebApp  // dotnet new mvc -n MvcWebApp command is used to create a new ASP.NET Core MVC application named "MvcWebApp". MVC (Model-View-Controller) is a design pattern that separates an application into three main components: the model, which represents the data and business logic; the view, which handles the presentation layer; and the controller, which manages user input and interactions. This command sets up the necessary project structure, files, and dependencies for an MVC application, allowing developers to build web applications with a clear separation of concerns and maintainable code.
//dotnet new webapp -n RazorPagesApp // dotnet new webapp -n RazorPagesApp command is used to create a new ASP.NET Core Razor Pages application named "RazorPagesApp". Razor Pages is a page-based programming model that makes building web UI easier and more productive. This command sets up the necessary project structure, files, and dependencies for a Razor Pages application, allowing developers to start building web pages with server-side logic and dynamic content.
//dotnet new webapi -n MinimalApi  // dotnet new webapi -n MinimalApi
//dotnet new webapi --use-controllers -n WebApiControllers // dotnet new webapi --use-controllers -n WebApiControllers

//dotnet sln add EmptyWebApp/EmptyWebApp.csproj // dotnet new web application create zala
//dotnet sln add MvcWebApp/MvcWebApp.csproj  // mvc application
//dotnet sln add RazorPagesApp/RazorPagesApp.csproj// mvc madhe razor pages application create zala
//dotnet sln add MinimalApi/MinimalApi.csproj// minimal api application create zala 
//dotnet sln add WebApiControllers/WebApiControllers.csproj // web api controllers application create zala

//dotnet restore // dotnet restore command is used to restore the dependencies and tools of a .NET project. It downloads the necessary packages specified in the project file (e.g., .csproj) from NuGet or other configured package sources. This step is essential before building or running the application, as it ensures that all required libraries are available.
//dotnet build // dotnet build command is used to compile the source code of a .NET project into an executable or library. It processes the project files, compiles the code, and generates the necessary output files (e.g., DLLs or EXEs) in the specified output directory. This step is crucial for creating a runnable application or library from the source code.
//dotnet sln list // dotnet sln list command is used to display the list of projects that are included in a .NET solution file (.sln). It provides an overview of the projects that are part of the solution, allowing developers to see which projects are currently associated with the solution and their respective paths. This command is helpful for managing and organizing multiple projects within a single solution.
//dotnet run --project .\MvcWebApp\MvcWebApp.csproj //हा MvcWebApp Project Build करून Run करेल.
