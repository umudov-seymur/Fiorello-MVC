using Microsoft.AspNetCore.Mvc;

namespace Fiorello_MVC.Areas.AdminArea.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewData["title"] = "Dashboard";
            return View();
        }
    }
}
