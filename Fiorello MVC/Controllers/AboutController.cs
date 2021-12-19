using Microsoft.AspNetCore.Mvc;

namespace Fiorello_MVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
