using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorello_MVC.Areas.Admin.ViewModels.ProductViewModel;
using Fiorello_MVC.DAL;
using Fiorello_MVC.Filter;
using Fiorello_MVC.Models;
using Fiorello_MVC.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("{area:exists}/Products/{action=Index}/{id:int?}")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData = await GetProductVmListAsync(validFilter.PageNumber, validFilter.PageSize);

            var totalRecords = await _context.Products
                    .Where(pr => pr.DeletedAt == null)
                    .CountAsync();
            
            return View(new PagedResponse<ProductCrudViewModel>(pagedData, validFilter.PageNumber, validFilter.PageSize, totalRecords));
        }

        public async Task<IActionResult> Create()
        {
            await GetActiveCategories();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            await GetActiveCategories();
            if (!ModelState.IsValid) return View();

            product.CreatedAt = DateTime.Now;

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            TempData["flashMessageTitle"] = "Product successfull created.";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            var dbProduct = await GetProductById((int) id);
            if (dbProduct == null) return BadRequest();
            
            await GetActiveCategories();

            return View(dbProduct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ProductCrudViewModel product)
        {
            if (id == null) return NotFound();
            var dbProduct = await GetProductById((int) id);
            if (dbProduct == null) return BadRequest();
            if (!ModelState.IsValid) return View(dbProduct);

            dbProduct.Id = product.Id;
            dbProduct.CategoryId = product.CategoryId;
            dbProduct.Name = product.Name;
            dbProduct.Price = product.Price;
            dbProduct.CreatedAt = product.CreatedAt;

            await _context.SaveChangesAsync();

            TempData["flashMessageTitle"] = "Product updated successfull.";

            return RedirectToAction("Index");
        }

        private async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            (await GetProductById(id)).DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return Json(new
            {
                success = true
            });
        }

        private async Task<List<ProductCrudViewModel>> GetProductVmListAsync(int pageNumber = 1, int pageSize = 10)
        {
            var productList = new List<ProductCrudViewModel>();
            var products = await _context.Products
                .Include(pr => pr.Category)
                .Include(pr => pr.ProductImages)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Where(pr => pr.DeletedAt == null)
                .OrderByDescending(pr => pr.Id)
                .ToListAsync(); 

            foreach (var product in products)
            {
                var productVm = new ProductCrudViewModel
                {
                    Id = product.Id,
                    CategoryId = product.CategoryId,
                    Name = product.Name,
                    Price = product.Price,
                    CategoryName = product.Category.Name,
                    CreatedAt = product.CreatedAt,
                    MainPhoto = product.ProductImages
                        .Where(img => img.IsMain == true)
                        .FirstOrDefault()
                        ?.Image
                };
                productList.Add(productVm);
            }

            return productList;
        }

        private async Task GetActiveCategories()
        {
            ViewBag.Categories = new SelectList(await _context.ProductCategories
                .Where(cat => cat.DeletedAt == null)
                .ToListAsync(), "Id", "Name");
        }
    }
}