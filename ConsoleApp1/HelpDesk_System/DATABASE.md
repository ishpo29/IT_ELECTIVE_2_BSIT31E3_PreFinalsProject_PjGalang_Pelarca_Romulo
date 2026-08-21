# Database Schema Documentation (Part 1)

## 1. Departments
- Primary Key: Id (INTEGER)
- Columns: Name (TEXT), Description (TEXT, Nullable), IsActive (INTEGER)
- Relationships: Has many Employees, Has many Teams

## 2. Employees
- Primary Key: Id (INTEGER)
- Foreign Key: DepartmentId -> Departments(Id)
- Columns: FirstName (TEXT), LastName (TEXT), Email (TEXT), JobTitle (TEXT), HireDate (TEXT), IsActive (INTEGER)
- Relationships: Belongs to Department, Has many TeamMembers, TicketAssignments, TicketComments

## 3. Teams
- Primary Key: Id (INTEGER)
- Foreign Key: DepartmentId -> Departments(Id)
- Columns: Name (TEXT), Description (TEXT, Nullable)
- Relationships: Belongs to Department, Has many TeamMembers

## 4. TeamMembers
- Composite Primary Key: (TeamId, EmployeeId)
- Foreign Keys: TeamId -> Teams(Id), EmployeeId -> Employees(Id)
- Columns: JoinedAt (TEXT)

## 5. Customers
- Primary Key: Id (INTEGER)
- Columns: CompanyName (TEXT), ContactName (TEXT), Email (TEXT), Phone (TEXT, Nullable), CreatedAt (TEXT), IsActive (INTEGER)
- Relationships: Has many Tickets

## 6. Categories
- **Primary Key:** Id (INTEGER)
- **Columns:** Name (TEXT), Description (TEXT, Nullable)
- **Relationships:** Has many Tickets

## 7. Ticket
- **Primary Key:** Id (INTEGER)
- **Foreign Keys:** CustomerId -> Customers(Id), CategoryId -> Categories(Id)
- **Columns:** TicketNumber (TEXT), Title (TEXT), Description (TEXT), Priority (TEXT), Status (TEXT), CreatedAt (TEXT), UpdatedAt (TEXT, Nullable)
- **Relationships:** Belongs to Customer, Belongs to Category, Has many TicketAssignments, TicketComments, TicketHistory

## 8. TicketAssignments
- **Primary Key:** Id (INTEGER)
- **Foreign Keys:** TicketId -> Tickets(Id), AssignedToEmployeeId -> Employees(Id)
- **Columns:** AssignedAt (TEXT)

## 9. TicketComments
- **Primary Key:** Id (INTEGER)
- **Foreign Keys:** TicketId -> Tickets(Id), AuthorEmployeeId -> Employees(Id)
- **Columns:** CommentText (TEXT), CreatedAt (TEXT)
