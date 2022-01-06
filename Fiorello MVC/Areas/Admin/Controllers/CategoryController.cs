using System;
using System.Linq;
using System.Threading.Tasks;
using Fiorello_MVC.DAL;
using Fiorello_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("{area:exists}/Categories/{action=Index}/{id:int?}")]
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductCategories
                .Where(cat => cat.DeletedAt == null)
                .ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCategory category)
        {
            if (!ModelState.IsValid) return View();

            var isExistCategory = await _context.ProductCategories
                .AnyAsync(cat => cat.Name.ToLower().Trim() == category.Name.ToLower().Trim());

            if (isExistCategory)
            {
                ModelState.AddModelError("Name", "This category name is already exist.");
                return View(category);
            }
            
            category.CreatedAt = DateTime.Now;

            await _context.ProductCategories.AddAsync(category);
            await _context.SaveChangesAsync();

            TempData["flashMessageTitle"] = "Category successfull created.";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            var dbCategory = await GetCategoryById((int)id);
            if (dbCategory == null) return BadRequest();

            return View(dbCategory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, ProductCategory category)
        {
            var dbCategory = await GetCategoryById(id);
            if (dbCategory == null) return BadRequest();
            if (!ModelState.IsValid) return View(dbCategory);
            if (category.Name.ToLower().Trim() != dbCategory.Name.ToLower().Trim())
            {
                var isExistCategory = await _context.ProductCategories
                    .AnyAsync(cat => cat.Name.ToLower().Trim() == category.Name.ToLower().Trim());

                if (isExistCategory)
                {
                    ModelState.AddModelError("Name", "This category name is already exist.");
                    return View(dbCategory);
                }
            }

            dbCategory.Name = category.Name.Trim();

            await _context.SaveChangesAsync();

            TempData["flashMessageTitle"] = "Category updated successfull.";

            return RedirectToAction("Index");
        }

        private async Task<ProductCategory> GetCategoryById(int id)
        {
            return await _context.ProductCategories
                .Where(cat => cat.Id == id)
                .FirstOrDefaultAsync();
        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var dbCategory = await GetCategoryById(id);
            dbCategory.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return Json(
                new
                {
                    success = true
                });
        }
        
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Restore(int id)
        // {
        //     var dbCategory = await GetCategoryById(id);
        //     dbCategory.DeletedAt = null;
        //
        //     await _context.SaveChangesAsync();
        //     
        //     TempData["flashMessageTitle"] = $"{dbCategory.Name} restored successfull.";
        //
        //     return RedirectToAction("Index");
        // }
    }
}