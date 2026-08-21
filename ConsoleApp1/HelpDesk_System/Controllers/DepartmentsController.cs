using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpDesk_System.Data;
using HelpDesk_System.Models.ViewModels;

namespace HelpDesk_System.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly AppDbContext _context;
        public DepartmentsController(AppDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            var departments = await _context.Departments
                .Include(d => d.Employees)
                .ToListAsync();

            return View(departments);
        }

        public async Task<IActionResult> Workload()
        {
            var workload = await _context.Departments
                .Select(d => new DepartmentWorkloadViewModel
                {
                    DepartmentId = d.Id,
                    DepartmentName = d.Name,
                    EmployeeCount = d.Employees.Count,
                    UnresolvedTicketCount = d.Employees
                        .SelectMany(e => e.TicketAssignments)
                        .Count(a => a.UnassignedAt == null && !a.Ticket.Status.IsClosed)
                })
                .ToListAsync();

            return View(workload);
        }
    }
}