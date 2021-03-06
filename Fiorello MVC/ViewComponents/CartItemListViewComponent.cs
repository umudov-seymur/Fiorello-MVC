using Fiorello_MVC.DAL;
using Fiorello_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fiorello_MVC.Helpers;

namespace Fiorello_MVC.ViewComponents
{
    public class CartItemListViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public CartItemListViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(List<CartViewModel> items = null)
        {
            var cartItems = items ?? (
                Request.Cookies["cartItems"] == null
                    ? new List<CartViewModel>()
                    : JsonConvert.DeserializeObject<List<CartViewModel>>(Request.Cookies["cartItems"])
            );

            return View(await CartHelper.GetCartProducts(_context, cartItems));
        }
    }
}