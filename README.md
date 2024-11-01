## TaskerAPI - ASP.NET Core Backend

TaskerAPI is the backend API for the Task Management App, built using ASP.NET Core. It handles user authentication, role-based access control, and task CRUD operations.

## Overview

This API supports the following features:

-   User registration and authentication using JWT.
-   Task management with Create, Read, Update, and Delete (CRUD) operations.
-   Role-based access control (RBAC) to manage permissions for users.

## Tech Stack

-   **ASP.NET Core**: Framework for building the API.
-   **Entity Framework Core**: ORM for database management.
-   **MySQL**: Database used for storing users and tasks.
-   **JWT**: For user authentication.

## Installation

### Prerequisites

-   **.NET SDK** (v6 or higher)
-   **MySQL** (Database)

### Steps

1.  **Clone the repository**: bash git clone [https://github.com/rugut-dev/tasker-api.git](https://github.com/rugut-dev/tasker-api.git) cd tasker-api
    
2.  **Install dependencies**: bash dotnet restore
    
3.  **Configure MySQL Database**:
    
    -   Update the appsettings.json file with your MySQL connection string.
4.  **Run database migrations**: bash dotnet ef database update
    
5.  **Run the API**: bash dotnet run
    

## API Endpoints (Find Rest in App)

### Authentication

-   **Register** - POST /api/auth/register
    
    -   Registers a new user.
    -   **Body**: json { "email": "user@example.com", "password": "yourPassword" }
-   **Login** - POST /api/auth/login
    
    -   Logs in an existing user and returns a JWT.
    -   **Body**: json { "email": "user@example.com", "password": "yourPassword" }

### Tasks

-   **Get All Tasks** - GET /api/tasks
    
    -   Retrieves all tasks for the authenticated user.
-   **Get Task by ID** - GET /api/tasks/{id}
    
    -   Retrieves a specific task by its ID.
-   **Create Task** - POST /api/tasks
    
    -   Creates a new task.
    -   **Body**: json { "title": "New Task", "description": "Task description", "dueDate": "2024-12-31" }
-   **Update Task** - PUT /api/tasks/{id}
    
    -   Updates an existing task.
    -   **Body**: json { "title": "Updated Task Title", "description": "Updated description", "dueDate": "2024-12-31" }
-   **Delete Task** - DELETE /api/tasks/{id}
    
    -   Deletes a task by its ID.

### Role-Based Access Control

-   **Admin-Only Task Management** - Admin users have additional endpoints for managing all users' tasks. Non-admin users can only manage their own tasks.

## Testing

Use Postman or Insomnia to test the API endpoints. Make sure to include the JWT token in the Authorization header for protected routes:

Authorization: Bearer <JWT_TOKEN>

## License

This project is licensed under the MIT License.

## Seeded Super Admin User

**Important Note:** This section is intended for development purposes only. Seeding a super admin user directly in the readme file is not recommended for production environments. Consider using environment variables or a separate configuration file to store sensitive information like the super admin credentials.

For development purposes, the following super admin user details are seeded on the database:

-   Username: superadmin
-   Email: superadmin@example.com
-   Password: superadminPass@123 (hashed with BCrypt)
-   Role: SuperAdmin
