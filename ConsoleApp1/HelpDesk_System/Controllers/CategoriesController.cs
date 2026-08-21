using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpDesk_System.Data;
using HelpDesk_System.Models.ViewModels;

namespace HelpDesk_System.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        public async Task<IActionResult> Hierarchy()
        {
            var categories = await _context.Categories
                .Include(c => c.Parent)
                .Select(c => new CategoryHierarchyViewModel
                {
                    CategoryId = c.Id,
                    CategoryName = c.Name,
                    ParentCategoryName = c.Parent != null ? c.Parent.Name : "None (Root Category)"
                })
                .ToListAsync();

            return View(categories);
        }
    }
}