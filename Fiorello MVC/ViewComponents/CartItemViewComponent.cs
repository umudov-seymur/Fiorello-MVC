using Fiorello_MVC.DAL;
using Fiorello_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_MVC.ViewComponents
{
    public class CartItemViewComponent : ViewComponent
    {
        public readonly AppDbContext _context;

        public CartItemViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(CartViewModel cartItem)
        {
            var product = _context.Products
                .Where(product => product.Id == cartItem.ProductId)
                .Include(product => product.ProductImages)
                .FirstOrDefault();

            ViewData["Quantity"] = cartItem.Count; 

            return View(product);
        }
    }
}
