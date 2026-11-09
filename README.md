# 🚀 DOT-NET Learning and Projects

A collection of C#, .NET, ASP.NET Core, C++, Data Structures and Algorithms (DSA), and Machine Learning projects and study materials.

This repository contains practical projects, coding examples, learning resources, and development exercises created to improve programming skills and understand software development concepts.

Each project folder is independent unless it contains a solution file that groups multiple projects.

---

## 📌 About the Repository

The purpose of this repository is to organize and maintain my learning journey in software development.

It includes:

- C# programming and Object-Oriented Programming (OOP)
- .NET application development
- ASP.NET Core Web Applications
- RESTful APIs and backend development
- Database connectivity and data access
- Data Structures and Algorithms
- C++ programming practice
- Machine Learning and Data Science study materials
- E-Commerce and Fund Transfer applications

This repository is useful for learning, practicing, experimenting, and building a strong foundation in software development.

---

## 🛠️ Technologies Used

| Technology | Description |
|---|---|
| C# | Application development and programming practice |
| .NET | Framework for building applications and services |
| ASP.NET Core | Web applications and backend APIs |
| C++ | Programming practice and problem-solving |
| Dapper | Database access and query execution |
| SQL | Database operations and data management |
| HTML | Web page structure |
| CSS | Web page styling |
| JavaScript | Client-side programming |
| Machine Learning | Data science and ML learning materials |
| Git | Version control |
| GitHub | Source code hosting and project management |

*The technologies used may vary depending on the individual project.*

---

## 📂 Repository Contents

| Folder | Description |
|---|---|
| `Account FundTransfer/` | C# fund-transfer application organized into listeners, UI, models, notifications, file management, and transaction management. |
| `AspNetCoreDemo/` | ASP.NET Core examples covering Empty Web App, Minimal API, MVC, Razor Pages, and controller-based Web API. |
| `CIE/` | .NET backend project, database schema, and documentation. See [CIE README](./CIE/README.md) for setup and API details. |
| `CollectionDemoApp/` | C# collection example using `Player` and `Team` classes. |
| `cpp/` | C++ practice programs and related run/debug files. |
| `DapperApi/` | ASP.NET Core API project using Dapper for database access. |
| `dotnet/` | .NET commerce projects, including `ECommerce/` and `EcommercePortal1/`. |
| `DSA-CSharp/` | C# Data Structures and Algorithms examples covering arrays, graphs, hashing, linked lists, queues, recursion, searching, sorting, stacks, and trees. |
| `ECommercePortal/` | ASP.NET Core E-Commerce portal containing controllers, models, views, and static web assets. |
| `FundTransferManager/` | Fund-transfer application organized into data, handlers, models, repositories, routes, services, transaction managers, and UI managers. |
| `FundTransferManager4147/` | Additional fund-transfer project under `FundTransferManager/`. |
| `Machine Learning/` | Machine Learning and Data Science study notes and reference documents. |
| `practice c#/` | C# and .NET practice projects covering APIs, authentication, OOP, and other programming exercises. |
| `ProductCatalogAPI/` | ASP.NET Core Product Catalog API with a sample HTTP request file. |
| `smart-age-calculator/` | Age Calculator project. See [Age Calculator README](./smart-age-calculator/README.md) for project notes. |
| `Transflower-Project/` | Project resources, including the `transflower-bootstrap/` folder. |
| `Trinity/` | Project files under the nested `Trinity/` folder. |
| `WebSolution/` | .NET solution containing Orders API, Product Catalog API, Portal, and Test Web App projects. |

---

## ⭐ Featured Projects

### 1. ASP.NET Core Demo

**Folder:** `AspNetCoreDemo/`

Learning examples for different ASP.NET Core application types.

Topics include:

- Empty Web Application
- Minimal API
- MVC
- Razor Pages
- Controller-based Web API

### 2. Product Catalog API

**Folder:** `ProductCatalogAPI/`

An ASP.NET Core API project for practicing product catalog functionality and HTTP requests.

### 3. Dapper API

**Folder:** `DapperApi/`

A backend API project demonstrating database access using Dapper.

### 4. E-Commerce Portal

**Folder:** `ECommercePortal/`

An ASP.NET Core web application organized into controllers, models, views, and static assets.

### 5. Fund Transfer Applications

**Folders:**
- `Account FundTransfer/`
- `FundTransferManager/`
- `FundTransferManager4147/`

These projects demonstrate application organization, transaction management, models, services, repositories, and user interface components.

### 6. Data Structures and Algorithms

**Folder:** `DSA-CSharp/`

C# practice examples covering:

- Arrays
- Linked Lists
- Stacks
- Queues
- Trees
- Graphs
- Hashing
- Searching
- Sorting
- Recursion

### 7. Machine Learning

**Folder:** `Machine Learning/`

Study materials, reference documents, and learning resources related to Machine Learning and Data Science.

---

## 🎯 Learning Objectives

Through these projects, I am focusing on:

- Understanding C# programming fundamentals
- Practicing Object-Oriented Programming
- Building applications using .NET
- Developing backend applications using ASP.NET Core
- Creating and understanding REST APIs
- Learning database connectivity and data access
- Understanding application architecture
- Improving problem-solving skills through DSA
- Practicing C++ programming
- Exploring Machine Learning concepts
- Using Git and GitHub for version control

---

## 💻 Getting Started

Follow these steps to run an individual project.

### Prerequisites

Install the following tools:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or Visual Studio Code
- [Git](https://git-scm.com/)
- SQL Server or another database, if required by the selected project

Some projects may require additional tools, packages, or configuration.

### 1. Clone the Repository

```bash
git clone YOUR_REPOSITORY_URL
```

Replace `YOUR_REPOSITORY_URL` with your actual GitHub repository URL.

### 2. Navigate to the Repository

```bash
cd DOT-NET
```

### 3. Select a Project

Navigate to the project folder you want to run.

For example:

```bash
cd ProductCatalogAPI
```

### 4. Check the Target Framework

Open the project's `.csproj` file.

Check the target framework:

```xml
<TargetFramework>net8.0</TargetFramework>
```

The example above uses .NET 8. Your actual project may use a different framework version.

Install a compatible .NET SDK before running the project.

### 5. Restore Dependencies

```bash
dotnet restore
```

This command restores the required NuGet packages.

### 6. Build the Project

```bash
dotnet build
```

This command compiles the project and checks for build errors.

### 7. Run the Project

```bash
dotnet run
```

For an ASP.NET Core application, the terminal will display the local application URL when the server starts successfully.

Open the displayed URL in your browser.

---

## 🧩 Running a .NET Solution

Some folders contain multiple projects grouped into a solution.

For example:

`WebSolution/`

Navigate to the folder containing the `.sln` or `.slnx` file.

Run:

```bash
dotnet restore
dotnet build
dotnet run
```

If the solution contains multiple executable projects, select the appropriate startup project in Visual Studio or run the required project directly.

Example:

```bash
dotnet run --project OrdersAPI
```

Replace `OrdersAPI` with the actual project path or project file name.

---

## 🗄️ Database Configuration

Some applications require database connectivity.

Before running a database-dependent project:

1. Check the project's README documentation.
2. Identify the database used by the application.
3. Configure the connection string.
4. Create or update the required database schema.
5. Apply migrations if the project uses Entity Framework Core migrations.
6. Run the application.

Database configuration may differ between projects.

Do not use production database credentials in source code or public repositories.

---

## 📁 Project Structure

The repository contains multiple independent projects.

A simplified structure:

```text
DOT-NET/
│
├── README.md
│
├── Account FundTransfer/
│
├── AspNetCoreDemo/
│
├── CIE/
│   └── README.md
│
├── CollectionDemoApp/
│
├── cpp/
│
├── DapperApi/
│
├── dotnet/
│   ├── ECommerce/
│   └── EcommercePortal1/
│
├── DSA-CSharp/
│
├── ECommercePortal/
│
├── FundTransferManager/
│
├── FundTransferManager4147/
│
├── Machine Learning/
│
├── practice c#/
│
├── ProductCatalogAPI/
│
├── smart-age-calculator/
│   └── README.md
│
├── Transflower-Project/
│
├── Trinity/
│
└── WebSolution/
```

The actual repository may contain additional files and subfolders.

---

## 🔧 Development Workflow

The general development workflow used for these projects:

1. Select a project.
2. Understand its folder structure.
3. Review the source code.
4. Restore dependencies.
5. Configure required services.
6. Build the application.
7. Run the application.
8. Test the functionality.
9. Update documentation.
10. Commit and push changes to GitHub.

---

## 📚 Learning Resources

Useful official documentation:

- [C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [.NET Documentation](https://learn.microsoft.com/en-us/dotnet/)
- [ASP.NET Core Documentation](https://learn.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core Documentation](https://learn.microsoft.com/en-us/ef/core/)
- [Dapper Documentation](https://github.com/DapperLib/Dapper)
- [C++ Documentation](https://learn.microsoft.com/en-us/cpp/)
- [Git Documentation](https://git-scm.com/doc)
- [GitHub Documentation](https://docs.github.com/)

---

## 📝 Important Notes

- This repository contains multiple independent learning projects.
- The entire repository is not a single application that runs with one command.
- Each project may have its own dependencies and configuration.
- Some projects may require a database or additional services.
- Check the project-specific README before running an application.
- The `Machine Learning/` folder contains study materials rather than a single runnable software project.
- `bin/` and `obj/` folders contain generated .NET build files.
- Project-specific instructions take priority over the general setup instructions in this README.

---

## 🚀 Future Improvements

Possible future improvements include:

- Adding detailed documentation for each project
- Adding screenshots of web applications
- Adding API request and response examples
- Adding database setup instructions
- Adding automated testing
- Improving project architecture
- Adding deployment instructions
- Organizing learning resources by topic

---

## 👨‍💻 Author

**Sachin Kharat**

Aspiring Software Developer | C# | .NET | ASP.NET Core | Backend Development

This repository represents my learning journey, programming practice, and development projects.

---

## 📄 License

This repository is primarily maintained for learning and educational purposes.

A license has not been specified yet. Please check individual project files for their licensing information before using or redistributing code.

---

⭐ If you find these projects useful for learning, feel free to explore the repository and use the examples for educational purposes.

**Happy Coding! 🚀**
