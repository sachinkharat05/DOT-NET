# DOT-NET Learning and Projects

A collection of C#, .NET, ASP.NET Core, C++, data-structure, and machine-learning
projects and study materials. Each project folder is independent unless it
contains a solution file that groups multiple projects.

## Repository contents

| Folder | Description |
|---|---|
| `Account FundTransfer/` | C# fund-transfer application organized into listeners, UI, models, notifications, file management, and transaction management. |
| `AspNetCoreDemo/` | ASP.NET Core examples: empty web app, Minimal API, MVC, Razor Pages, and controller-based Web API. |
| `CIE/` | .NET backend, database schema, and documentation. See [`CIE/README.md`](./CIE/README.md) for setup and API details. |
| `CollectionDemoApp/` | C# collection example with `Player` and `Team` classes. |
| `cpp/` | C++ practice programs and related run/debug files. |
| `DapperApi/` | ASP.NET Core API project using Dapper. |
| `dotnet/` | .NET commerce projects: `ECommerce/` and `EcommercePortal1/`. |
| `DSA-CSharp/` | C# data-structure and algorithm examples covering arrays, graphs, hashing, linked lists, queues, recursion, searching, sorting, stacks, and trees. |
| `ECommercePortal/` | ASP.NET Core e-commerce portal with controllers, models, views, and static web assets. |
| `FundTransferManager/` | Fund-transfer application organized into data, handlers, models, repositories, routes, services, transaction managers, and UI managers. |
| `FundTransferManager4147/` | Additional fund-transfer project under `FundTransferManager/`. |
| `Machine Learning/` | Machine-learning and data-science study notes and reference documents. |
| `practice c#/` | C# and .NET practice projects, including API, authentication, OOP, and other exercises. |
| `ProductCatalogAPI/` | ASP.NET Core product-catalog API with a sample HTTP request file. |
| `smart-age-calculator/` | Age-calculator project. See [`smart-age-calculator/README.md`](./smart-age-calculator/README.md) for its project notes. |
| `Transflower-Project/` | Project resources, including the `transflower-bootstrap/` folder. |
| `Trinity/` | Project files under the nested `Trinity/` folder. |
| `WebSolution/` | .NET solution containing Orders API, Product Catalog API, Portal, and Test Web App projects. |

## Getting started

1. Install the .NET SDK required by the project you want to run. Check its
   `.csproj` file for the target framework.
2. Open a terminal in the project folder.
3. Restore and build the project:

   ```powershell
   dotnet restore
   dotnet build
   ```

4. For an executable application, start it with:

   ```powershell
   dotnet run
   ```

For a solution, run the commands from the folder containing its `.sln` or
`.slnx` file. Some applications may also require local configuration, a
database, or other services; check the project-specific documentation and
configuration before running them.

## Notes

- The repository contains multiple independent learning projects, not one
  application that runs as a whole.
- `bin/` and `obj/` folders, where present, contain generated .NET build files.
- The `Machine Learning/` folder contains study materials rather than a single
  runnable software project.
