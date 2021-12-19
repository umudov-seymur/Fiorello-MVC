using Fiorello_MVC.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Fiorello_MVC.ViewComponents
{
    public class TestimonialListViewComponent : ViewComponent
    {
        public readonly AppDbContext _context;

        public TestimonialListViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var testimonials = await _context.Testimonials
                .Include(t => t.Author)
                .ToListAsync();
            return View(testimonials);
        }
    }
}
