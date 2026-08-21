using HelpDesk_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HelpDesk_System.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TicketAssignment> TicketAssignments { get; set; }
        public DbSet<TicketComment> TicketComments { get; set; }
        public DbSet<TicketTags> TicketTags { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<TicketAttachment> TicketAttachments { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }

    }
}