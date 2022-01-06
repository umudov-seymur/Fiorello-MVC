using System;
using System.Linq;
using System.Threading.Tasks;
using Fiorello_MVC.Areas.Admin.ViewModels;
using Fiorello_MVC.DAL;
using Fiorello_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Utilities.File.Extentions;
using Utilities.Helpers;

namespace Fiorello_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("{area:exists}/Sliders/{action=Index}/{id:int?}")]
    [Authorize]
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
            ViewBag.AllowedSliderCount = await GetAllowedSliderCount();
            return View(await _context.Sliders.ToListAsync());
        }

        public async Task<IActionResult> Create()
        {
            if (await IsMaxSliderExceeded()) return RedirectToAction("Index");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderViewModel slider)
        {
            if (!ModelState.IsValid) return View();
            if (await IsMaxSliderExceeded())
            {
                return Json(new
                {
                    success  = false,
                    errorMessage = $"You have exceeded the number of files allowed."
                });
            }
            
            var remainingSliderCount = await GetAllowedSliderCount() - _context.Sliders.Count();
            
            if (slider.Photos.Count() > remainingSliderCount)
            {
                return Json(new
                {
                    success  = false,
                    errorMessage = $"{remainingSliderCount} photos can be choiced."
                });
            }
            
            foreach (var photo in slider.Photos)
            {
                if (!ModelState.IsValid) return View();
            
                var fileName = await photo.UploadFile(_environment.WebRootPath, @"assets/img");
            
                await _context.Sliders.AddAsync(new Slider
                {
                    Image = fileName,
                    CreatedAt = DateTime.Now
                });
            
            }

            await _context.SaveChangesAsync();
                
            return Json(new
            {
                success = true
            });

            // if (await IsMaxSliderExceeded()) return RedirectToAction("Index");
            // if (!ModelState.IsValid) return View();
            //
            // var fileName = await slider.Photo.UploadFile(_environment.WebRootPath, @"assets/img");
            //
            // await _context.Sliders.AddAsync(new Slider
            // {
            //     Image = fileName,
            //     CreatedAt = DateTime.Now
            // });
            //
            // await _context.SaveChangesAsync();
            //
            // TempData["flashMessageTitle"] = "Slider successfull created.";
            //
            // return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            var dbSlider = await GetSliderById((int) id);
            if (dbSlider == null) return BadRequest();

            ViewBag.CurrentPhoto = dbSlider.Image;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, SliderViewModel slider)
        {
            // if (slider.Photo == null) return RedirectToAction("Index");
            // if (!ModelState.IsValid) return View();
            // if (id == null) return NotFound();
            // var dbSlider = await GetSliderById((int) id);
            // if (dbSlider == null) return BadRequest();
            //
            // FileHelper.RemoveFile(_environment.WebRootPath, $"assets/img/{dbSlider.Image}");
            //
            // var newFileName = await slider.Photo.UploadFile(_environment.WebRootPath, @"assets/img");
            //
            // dbSlider.Image = newFileName;
            //
            // await _context.SaveChangesAsync();
            //
            // TempData["flashMessageTitle"] = "Slider updated successfull.";

            return RedirectToAction("Index");
        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var dbSlider = await GetSliderById(id);

            _context.Sliders.Remove(dbSlider);

            FileHelper.RemoveFile(_environment.WebRootPath, $"assets/img/{dbSlider.Image}");

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

        private async Task<int> GetAllowedSliderCount()
        {
            return int.Parse(await Helpers.Helpers.Setting(_context, "allowed_sliders_count"));
        }

        private async Task<bool> IsMaxSliderExceeded()
        {
            var allowedSliderCount = await GetAllowedSliderCount();
            var slidersCount = await _context.Sliders.CountAsync();
            
            ViewBag.RemainingSliderCount = allowedSliderCount - slidersCount;

            if (slidersCount >= allowedSliderCount)
            {
                TempData["flashMessageTitle"] = $"You have exceeded the number of files allowed.";
                TempData["flashMessageIcon"] = "error";
                return true;
            }

            return false;
        }
    }
}