using System.Threading.Tasks;
using Fiorello_MVC.DAL;
using Fiorello_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Fiorello_MVC.Areas.AdminArea.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _context.ProductCategories.ToListAsync();

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCategory category)
        {
            if (!ModelState.IsValid) return View();
            
            await _context.ProductCategories.AddAsync(category);
            await _context.SaveChangesAsync();
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var category = await _context.ProductCategories
                .Where(cat => cat.Id == id)
                .FirstOrDefaultAsync();

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Update(int id, ProductCategory category)
        {
            return RedirectToAction("Update");
        }

        [HttpDelete]
        public IActionResult Destroy(int id)
        {
            return View();
        }
    }
}