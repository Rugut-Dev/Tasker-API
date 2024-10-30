
# Development Environment Setup for ASP.NET Core with MySQL on Ubuntu 22.04

## Step 1: Install .NET SDK on Ubuntu
1. **Install Required Dependencies:**
   ```bash
   sudo apt update
   sudo apt install -y apt-transport-https ca-certificates software-properties-common
   ```

2. **Add Microsoft Package Repository:**
   ```bash
   wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
   sudo dpkg -i packages-microsoft-prod.deb
   ```

3. **Install .NET SDK:**
   ```bash
   sudo apt update
   sudo apt install -y dotnet-sdk-8.0
   ```

4. **Verify Installation:**
   ```bash
   dotnet --version
   ```

## Step 2: Install C# Support for Visual Studio Code (Cursor)
1. Open VS Code (or Cursor) and go to the Extensions panel.
2. Search for 'C#' (by OmniSharp) and install it.

## Step 3: Install MySQL Database
1. **Update the package index:**
   ```bash
   sudo apt update
   ```
2. **Install MySQL Server:**
   ```bash
   sudo apt install -y mysql-server
   ```

## Step 4: Install Entity Framework Core (EF Core) for MySQL
1. **Install the EF Core Tool globally:**
   ```bash
   dotnet tool install --global dotnet-ef
   ```
2. **Add the EF Core provider for MySQL:**
   ```bash
   dotnet add package Pomelo.EntityFrameworkCore.MySql
   ```

## Step 5: Create Your ASP.NET Core API
1. **Create a new ASP.NET Core project:**
   ```bash
   dotnet new webapi -n MyApi
   cd MyApi
   ```
2. **Run the application:**
   ```bash
   dotnet run
   ```

## Step 6: Install Swagger for API Documentation (Optional)
1. **Add the Swagger package:**
   ```bash
   dotnet add package Swashbuckle.AspNetCore
   ```
2. **Configure Swagger in `Startup.cs` or `Program.cs`:**
   - Add in `ConfigureServices`:
     ```csharp
     services.AddSwaggerGen();
     ```
   - Add in `Configure` to enable Swagger UI:
     ```csharp
     app.UseSwagger();
     app.UseSwaggerUI(c =>
     {
         c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
     });
     ```

## Step 7: Testing Your API
- Test the API using Postman, Insomnia, or cURL.

## Step 8: Deploy Your API (Optional)
- Plan for deploying the API to a hosting service (e.g., Azure, AWS, DigitalOcean, or Heroku).

# Environment Established Successfully!
