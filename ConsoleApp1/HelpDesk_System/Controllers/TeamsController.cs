using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpDesk_System.Data;

namespace HelpDesk_System.Controllers
{
    public class TeamsController : Controller
    {
        private readonly AppDbContext _context;
        public TeamsController(AppDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            var teams = await _context.Teams
                .Include(t => t.Department)
                .Include(t => t.TeamMembers)
                    .ThenInclude(tm => tm.Employee)
                .ToListAsync();

            return View(teams);
        }
    }
}