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

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _context.Products
                    .Where(product => product.DeletedAt == null)
                    .Include(d => d.ProductImages)
                    .Include(d => d.Category)
                    .ToListAsync();

            return View(products);
        }
    }
}
