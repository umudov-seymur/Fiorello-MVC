using Fiorello_MVC.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_MVC.ViewComponents
{
    public class ProductListViewComponent : ViewComponent
    {
        public readonly AppDbContext _context;

        public ProductListViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? skip = 0)
        {
            var limit = await Helpers.Helpers.Setting(_context, "products_per_page");

            var products = await _context.Products
                    .Where(product => product.DeletedAt == null)
                    .Skip((int)skip)
                    .Take(int.Parse(limit))
                    .Include(d => d.ProductImages)
                    .Include(d => d.Category)
                    .ToListAsync();

            return View(products);
        }
    }
}