using Fiorello_MVC.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Fiorello_MVC.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        public readonly AppDbContext _context;

        public AboutViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.AboutImage = await Helpers.Helpers
                   .Setting(_context, "about_image");
            ViewBag.AboutText = await Helpers.Helpers
                    .Setting(_context, "about_text");

            return View();
        }
    }
}
