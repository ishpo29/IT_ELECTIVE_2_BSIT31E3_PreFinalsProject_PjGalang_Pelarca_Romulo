using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpDesk_System.Data;
using HelpDesk_System.Models.ViewModels;

namespace HelpDesk_System.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _context;
        public EmployeesController(AppDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employees.Include(e => e.Department).ToListAsync();
            return View(employees);
        }

        public async Task<IActionResult> Workload()
        {
            var workload = await _context.Employees
                .Where(e => e.IsActive)
                .Select(e => new EmployeeWorkloadViewModel
                {
                    EmployeeId = e.Id,
                    EmployeeName = e.FirstName + " " + e.LastName,
                    DepartmentName = e.Department.Name,
                    UnresolvedTicketCount = e.TicketAssignments
                        .Count(a => a.UnassignedAt == null && !a.Ticket.Status.IsClosed)
                })
                .ToListAsync();

            return View(workload);
        }
    }
}