# Database Schema Documentation

## 1. Departments
- Columns: Name (TEXT), Description (TEXT, Nullable), IsActive (INTEGER)

## 2. Employees
- Columns: FirstName (TEXT), LastName (TEXT), Email (TEXT), JobTitle (TEXT), HireDate (TEXT), IsActive (INTEGER)

## 3. Teams
- Columns: Name (TEXT), Description (TEXT, Nullable)


## 4. TeamMembers
- Columns: JoinedAt (TEXT)

## 5. Customers
- Columns: CompanyName (TEXT), ContactName (TEXT), Email (TEXT), Phone (TEXT, Nullable), CreatedAt (TEXT), IsActive (INTEGER)


## 6. Categories
- **Columns:** Name (TEXT), Description (TEXT, Nullable)

## 7. Ticket
- **Columns:** TicketNumber (TEXT), Title (TEXT), Description (TEXT), Priority (TEXT), Status (TEXT), CreatedAt (TEXT), UpdatedAt (TEXT, Nullable)

## 8. TicketAssignments
- **Columns:** AssignedAt (TEXT)

## 9. TicketComments
- **Columns:** CommentText (TEXT), CreatedAt (TEXT)

## comment