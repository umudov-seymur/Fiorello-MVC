using Fiorello_MVC.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_MVC.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
