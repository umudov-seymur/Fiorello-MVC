using Fiorello_MVC.DAL;
using Fiorello_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Fiorello_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        static HttpClient client = new HttpClient();

        public HomeController(AppDbContext context)
        {
            _context = context;
            client.BaseAddress = new Uri("https://www.instagram.com/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel ViewModel = new HomeViewModel
            {
                Sliders = await _context.Sliders
                    .Where(slider => slider.DeletedAt == null)
                    .ToListAsync(),
                Experts = await _context.Experts
                    .Where(expert => expert.DeletedAt == null)
                    .Include(d => d.Position)
                    .ToListAsync()
            };

            return View(ViewModel);
        }
    }
}
