using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpDesk_System.Data;
using HelpDesk_System.Models;
using HelpDesk_System.Models.ViewModels;

namespace HelpDesk_System.Controllers
{
    public class TicketsController : Controller
    {
        private readonly AppDbContext _context;

        public TicketsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tickets = await _context.Tickets
                .Include(t => t.Customer)
                .Include(t => t.Category)
                .Include(t => t.Priority)
                .Include(t => t.Status)
                .Include(t => t.TicketAssignments)
                    .ThenInclude(a => a.Employee)
                .ToListAsync();

            return View(tickets);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var ticket = await _context.Tickets
                .Include(t => t.Customer)
                .Include(t => t.Category)
                .Include(t => t.Priority)
                .Include(t => t.Status)
                .Include(t => t.TicketAssignments)
                    .ThenInclude(a => a.Employee)
                .Include(t => t.TicketComments)
                .Include(t => t.TicketTags)
                    .ThenInclude(tt => tt.Tags)
                .Include(t => t.TicketAttachments)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (ticket == null) return NotFound();

            return View(ticket);
        }

        public async Task<IActionResult> Unassigned()
        {
            var tickets = await _context.Tickets
                .Where(t => !t.TicketAssignments.Any(a => a.UnassignedAt == null))
                .Select(t => new UnassignedTicketViewModel
                {
                    TicketId = t.Id,
                    Subject = t.Subject,
                    CustomerName = t.Customer.ContactName,
                    Priority = t.Priority.Name,
                    Status = t.Status.Name,
                    CreatedAt = t.CreatedAt
                })
                .ToListAsync();

            return View(tickets);
        }

        public async Task<IActionResult> MultipleAssignees()
        {
            var tickets = await _context.Tickets
                .Where(t => t.TicketAssignments.Count(a => a.UnassignedAt == null) > 1)
                .Select(t => new MultipleAssigneeTicketViewModel
                {
                    TicketId = t.Id,
                    Subject = t.Subject,
                    ActiveAssigneeCount = t.TicketAssignments.Count(a => a.UnassignedAt == null),
                    Assignees = t.TicketAssignments
                        .Where(a => a.UnassignedAt == null)
                        .Select(a => a.Employee.FirstName + " " + a.Employee.LastName)
                        .ToList()
                })
                .ToListAsync();

            return View(tickets);
        }

        public async Task<IActionResult> PrimaryAssignees()
        {
            var tickets = await _context.Tickets
                .Select(t => new PrimaryAssigneeViewModel
                {
                    TicketId = t.Id,
                    Subject = t.Subject,
                    PrimaryAssignee = t.TicketAssignments
                        .Where(a => a.IsPrimary && a.UnassignedAt == null)
                        .Select(a => a.Employee.FirstName + " " + a.Employee.LastName)
                        .FirstOrDefault() ?? "Unassigned"
                })
                .ToListAsync();

            return View(tickets);
        }
    }
}