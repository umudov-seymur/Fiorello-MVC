using Fiorello_MVC.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_MVC.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var settings = _context.Settings
                .AsEnumerable()
                .ToDictionary(s => s.Key, s => s.Value);
            
            return View(await Task.FromResult(settings));
        }
    }
}
