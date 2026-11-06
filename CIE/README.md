# CIE .NET Backend

This is a .NET-only ASP.NET Core Web API. It uses a repository to read and
write student prompts in MySQL.

## Files

```text
CIE/
├── backend/CIE.Api/
│   ├── Controllers/       API routes
│   ├── Models/            Database model and request/response types
│   ├── Repositories/      MySQL queries and data access
│   ├── Services/          Application logic
│   ├── Program.cs         Dependency injection and API startup
│   └── run-local.ps1      Prompts for the local MySQL password and starts API
└── database/schema.sql    Database and table definition
```

## Run the API

Requirements: .NET 10 SDK and MySQL 8 with the `MySQL80` service running.

1. Open a terminal in the `CIE` folder.
2. Execute `database/schema.sql` in MySQL Workbench, or let the API create the
   database and table on first startup.
3. Run:

   ```powershell
   .\backend\CIE.Api\run-local.ps1
   ```

4. Enter the local MySQL `root` password when PowerShell asks for it. The
   password is not stored in the repository.

The API starts at `http://localhost:5205`. Swagger is at
`http://localhost:5205/swagger`.

## Routes

| Method | Route | What it does |
|---|---|---|
| `GET` | `/api/health` | Checks the MySQL connection |
| `GET` | `/api/prompts` | Returns all saved prompts |
| `GET` | `/api/prompts/{id}` | Returns one prompt |
| `POST` | `/api/prompts` | Saves a new prompt |

Example `POST /api/prompts` JSON:

```json
{
  "studentId": "ST001",
  "sessionId": "SESSION001",
  "promptText": "What is dependency injection?"
}
```

Try the requests in `backend/CIE.Api/CIE.Api.http`. The API returns
`400 Bad Request` for invalid input and `404 Not Found` when a prompt ID does
not exist.

## Build

From the `CIE` folder:

```powershell
dotnet build .\backend\CIE.Api\CIE.Api.csproj
```
