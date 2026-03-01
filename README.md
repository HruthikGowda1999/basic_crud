# basic_crud
Generic CRUD API built with ASP.NET Core Web API and Entity Framework Core, implementing RESTful endpoints with validation and API versioning.

## Tech Stack
- ASP.NET Core (.NET 9)
- Entity Framework Core
- PostgreSQL (Supabase)

## Features
- API Versioning (v1)
- CRUD Operations
- Model Validation
- Proper HTTP Status Codes

## Endpoints

GET     /api/v1/employees  
GET     /api/v1/employees/{id}  
POST    /api/v1/employees  
PUT     /api/v1/employees/{id}  
DELETE  /api/v1/employees/{id}  

## Setup Instructions

1. Clone the repository
2. Update the connection string in `appsettings.json`
3. Run:
   dotnet ef database update
   dotnet run

Swagger UI will open for testing.
