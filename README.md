# HelpDesk System

## Project Description

The **HelpDesk System** is an ASP.NET Core MVC web application designed to manage and organize support tickets. The system allows users to manage departments, employees, teams, customers, categories, and support tickets.

It also provides features for ticket assignment, comments, attachments, workload monitoring, unassigned tickets, multiple assignees, primary assignees, and category hierarchy.

## Technologies Used

* ASP.NET Core MVC
* C#
* Entity Framework Core
* SQLite
* HTML
* CSS
* JavaScript

## Project Structure

```text
HelpDesk_System/
└── HelpDesk_System/
    ├── Controllers/
    ├── Data/
    ├── Models/
    │   └── ViewModels/
    ├── Views/
    │   └── Shared/
    ├── wwwroot/
    ├── Program.cs
    ├── appsettings.json
    ├── lycevm.db
    └── HelpDesk_System.csproj
```

## Main Features

* Department Management
* Employee Management
* Team Management
* Customer Management
* Category Management
* Ticket Management
* Ticket Assignments
* Ticket Comments
* Ticket Attachments
* Employee Workload Monitoring
* Department Workload Monitoring
* Unassigned Tickets
* Multiple Assignee Tickets
* Primary Assignee Tracking
* Category Hierarchy

## Database

The project uses **SQLite** as its database.

Database file:

```text
lycevm.db
```

The database schema and table documentation can be found in:

```text
DATABASE.md
```

## Developers

* Galang, Peter Joshua F.
* Pelarca, Harvey Ischei O.
* Romulo, Jeremiah C.

## Git Workflow

The project follows a feature branch and Pull Request workflow.

```text
main
 │
 ├── feature/p1-...
 ├── feature/p2-...
 └── feature/p3-...
```

Each developer:

1. Pulls the latest `main` branch.
2. Creates their assigned feature branch.
3. Works on their assigned files or sections.
4. Commits their changes.
5. Pushes the branch to GitHub.
6. Creates a Pull Request.
7. Has the changes reviewed.
8. Merges the Pull Request into `main`.

Direct commits to the `main` branch should be avoided.

## How to Run the Project

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Make sure the database file `lycevm.db` is included in the project.
4. Restore the required NuGet packages.
5. Build the project.
6. Run the application.

## License

This project was developed for educational purposes.
