using Fiorello_MVC.DAL;
using Fiorello_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Fiorello_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel ViewModel = new HomeViewModel
            {
                Sliders = await _context.Sliders
                    .Include(d => d.Image)
                    .ToListAsync(),
                ProductCategories = await _context.ProductCategories.ToListAsync(),
                Products = await _context.Products
                    .Include(d => d.Image)
                    .Include(d => d.Category)
                    .ToListAsync(),
                Experts = await _context.Experts
                    .Include(d => d.Image)
                    .Include(d => d.Position)
                    .ToListAsync(),
                Blogs = await _context.Blogs
                    .Include(d => d.Image)
                    .ToListAsync()
            };

            return View(ViewModel);
        }
    }
}
