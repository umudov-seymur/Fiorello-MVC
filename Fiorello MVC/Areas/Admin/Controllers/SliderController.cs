using System;    
using System.Threading.Tasks;
using Fiorello_MVC.DAL;
using Fiorello_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Fiorello_MVC.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Utilities.File.Extentions;
using Utilities.File.Helpers;

namespace Fiorello_MVC.Areas.AdminArea.Controllers
{
    [Area("Admin")]
    [Route("{area:exists}/Sliders/{action=Index}/{id:int?}")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public SliderController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Sliders.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderViewModel slider)
        {
            if (!ModelState.IsValid) return View();

            var fileName = $"{Guid.NewGuid()}_{slider.Photo.FileName}";
            
            slider.Photo.UploadFile(_environment.WebRootPath, @"assets/img", fileName);
            
            await _context.Sliders.AddAsync(new Slider
            {
                Image = fileName,
                CreatedAt = DateTime.Now
            });
            
            await _context.SaveChangesAsync();

            TempData["flashMessageTitle"] = "Slider successfull created.";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            var dbSlider = await GetSliderById((int) id);
            if (dbSlider == null) return BadRequest();

            SliderViewModel slider = new SliderViewModel
            {
                CurrentPhoto = dbSlider.Image
            };

            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, SliderViewModel slider)
        {
            // var dbSlider = await GetSliderById(id);
            //
            // if (!ModelState.IsValid) return View(dbSlider);
            // if (dbSlider == null) return BadRequest();
            //
            // await _context.SaveChangesAsync();
            //
            // TempData["flashMessageTitle"] = "Slider updated successfull.";
            //
            // return RedirectToAction("Index");
        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var dbSlider = await GetSliderById(id);

            _context.Sliders.Remove(dbSlider);
            
            FileHelpers.RemoveFile(_environment.WebRootPath, $"assets/img/{dbSlider.Image}");
            
            await _context.SaveChangesAsync();

            return Json(
                new
                {
                    success = true
                });
        }

        private async Task<Slider> GetSliderById(int id)
        {
            return await _context.Sliders
                .Where(slider => slider.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}