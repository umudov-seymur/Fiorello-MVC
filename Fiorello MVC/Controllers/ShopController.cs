using Microsoft.AspNetCore.Mvc;

namespace Fiorello_MVC.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
