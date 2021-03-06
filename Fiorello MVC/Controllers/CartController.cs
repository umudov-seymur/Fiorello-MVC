using Fiorello_MVC.DAL;
using Fiorello_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fiorello_MVC.Helpers;

namespace Fiorello_MVC.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;

        private List<CartViewModel> CartItemList
        {
            get
            {
                var cartItems = Request.Cookies["cartItems"];
                return cartItems == null
                     ? new List<CartViewModel>()
                     : JsonConvert.DeserializeObject<List<CartViewModel>>(cartItems);
            }
            set => Response.Cookies.Append("cartItems", JsonConvert.SerializeObject(value));
        }

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await CartHelper.GetCartProducts(_context, CartItemList));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToCart(int? productId)
        {
            if (productId == null) return NotFound();
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return BadRequest();

            return Json(new
            {
                itemsCount = (await UpdateCart(product.Id)).Count
            });
            
            // return ViewComponent("CartItemList", await UpdateCart(product.Id));
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult List()
        {
            return ViewComponent("CartItemList");
        }

        private async Task<List<CartViewModel>> UpdateCart(int productId)
        {
            List<CartViewModel> cartItems = CartItemList;
            CartViewModel cartProduct = cartItems.Find(pr => pr.ProductId == productId);

            if (cartProduct == null)
            {
                cartItems.Add(new CartViewModel
                {
                    ProductId = productId,
                    Count = 1
                });
            }
            else
            {
                cartProduct.Count += 1;
            }

            CartItemList = cartItems;

            return await Task.FromResult(cartItems);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveCartItem(int? productId)
        {
            List<CartViewModel> cartItems = CartItemList;

            var product = cartItems.Find(cartItem => cartItem.ProductId == productId);
            cartItems.Remove(product);

            CartItemList = cartItems;

            return ViewComponent("CartItemList", cartItems);
        }
    }
}
