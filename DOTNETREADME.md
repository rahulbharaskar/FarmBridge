# FarmBridge (.NET with Razor Pages)

## Overview
FarmBridge is a full-stack application built using **ASP.NET Core** for the backend and **Razor Pages** for the frontend. This document provides details on setting up, running, and deploying the .NET-based solution.

## Prerequisites
Before running the project, ensure you have the following installed:
- **.NET SDK (Latest version)**
- **SQL Server** (or any supported database)
- **Visual Studio** or **VS Code** (Recommended for development)

---

## Setup and Installation

### Clone the Repository
```sh
git clone https://github.com/your-repo/FarmBridge-dotnet.git
cd FarmBridge-dotnet
```

### Restore Dependencies
```sh
dotnet restore
```

### Update Configuration
Modify `appsettings.json` to configure the database connection:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=FarmBridgeDB;User Id=sa;Password=yourpassword;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

### Apply Migrations (If using Entity Framework Core)
```sh
dotnet ef database update
```

### Run the Backend API
```sh
dotnet run --project FarmBridge-API
```
The backend will start at [http://localhost:5000](http://localhost:5000).

---

## Frontend (Razor Pages)

### Navigate to the Frontend Directory
```sh
cd FarmBridge-UI
```

### Run the Frontend Application
```sh
dotnet run
```
The frontend will be available at [http://localhost:5001](http://localhost:5001).

### Razor Pages Structure
The Razor Pages frontend follows the **MVVM (Model-View-ViewModel) pattern** with pages structured as follows:
```
FarmBridge-UI/
│-- Pages/
│   │-- Index.cshtml
│   │-- Index.cshtml.cs
│   │-- Users/
│   │   │-- List.cshtml
│   │   │-- List.cshtml.cs
│   │   │-- Create.cshtml
│   │   │-- Create.cshtml.cs
│   │-- Shared/
│   │   │-- _Layout.cshtml
│   │   │-- _ValidationScriptsPartial.cshtml
│-- wwwroot/
│   │-- css/
│   │-- js/
│-- Program.cs
│-- Startup.cs
```

---

## REST API Endpoints
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET    | /api/users | Fetch all users |
| POST   | /api/users | Add a new user |
| PUT    | /api/users/{id} | Update a user by ID |
| DELETE | /api/users/{id} | Delete a user by ID |

---

## Building and Deployment

### Build the Application
```sh
dotnet build
```
This will generate a `dll` file inside the `bin/Debug/net6.0/` directory.

### Running from DLL
```sh
dotnet bin/Debug/net6.0/FarmBridge-dotnet.dll
```

### Docker Support
To containerize the application, create a `Dockerfile`:
```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY . .
ENTRYPOINT ["dotnet", "FarmBridge-dotnet.dll"]
```
Then build and run the Docker container:
```sh
docker build -t farmbridge-dotnet .
docker run -p 5000:80 farmbridge-dotnet
```

### Deployment Options
- **Azure App Service**
- **AWS Elastic Beanstalk**
- **Docker + Kubernetes**
- **On-premise Servers**

---

## Troubleshooting
- Ensure SQL Server is running and the connection string is correct.
- Check logs for errors using:
```sh
dotnet run --verbose
```
- If migrations fail, try:
```sh
dotnet ef migrations add InitialCreate
```

---

## Learn More
For additional details, visit the [.NET documentation](https://dotnet.microsoft.com/).

