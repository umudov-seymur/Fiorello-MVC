using Fiorello_MVC.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_MVC.ViewComponents
{
    public class BlogListViewComponent : ViewComponent
    {
        public readonly AppDbContext _context;

        public BlogListViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int limit = 10)
        {
            var blogs = await _context.Blogs
                    .Where(blog => blog.DeletedAt == null)
                    .Take(limit)
                    .ToListAsync();

            return View(blogs);
        }
    }
}
