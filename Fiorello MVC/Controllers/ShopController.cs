using Fiorello_MVC.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Fiorello_MVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.ProductsCount = _context.Products.Count();
            return View();
        }

        public IActionResult GetProductsList(int skip)
        {
            return ViewComponent("ProductList", new { skip = skip });
        }
    }
}