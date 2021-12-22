using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorello_MVC.DAL;
using Fiorello_MVC.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_MVC.Helpers
{
    public static class CartHelper
    {
        public static async Task<List<CartProductViewModel>> GetCartProducts(AppDbContext context, List<CartViewModel> cartItems)
        {
            List<CartProductViewModel> cartProducts = new List<CartProductViewModel>();
       
            foreach (var cartItem in cartItems)
            {
                var product = await context.Products
                    .Include(pro => pro.ProductImages)
                    .FirstOrDefaultAsync(pro => pro.Id == cartItem.ProductId);

                CartProductViewModel cartProduct = new CartProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Image = product.ProductImages
                        .Where(productImage => productImage.IsMain == true)
                        .FirstOrDefault()
                        .Image,
                    Quantity = cartItem.Count
                };

                cartProducts.Add(cartProduct);
            }

            return cartProducts;
        }
    }
}