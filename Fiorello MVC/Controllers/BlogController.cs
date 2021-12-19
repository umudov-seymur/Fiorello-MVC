using Microsoft.AspNetCore.Mvc;

namespace Fiorello_MVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
