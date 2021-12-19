using Fiorello_MVC.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_MVC.ViewComponents
{
    public class ProductCategoryListViewComponent: ViewComponent
    {
        public readonly AppDbContext _context;

        public ProductCategoryListViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _context.ProductCategories
                    .Where(category => category.DeletedAt == null)
                    .ToListAsync();

            return View(categories);
        }
    }
}
