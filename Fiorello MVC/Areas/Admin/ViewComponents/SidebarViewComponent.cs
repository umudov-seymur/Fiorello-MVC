using System.Collections.Generic;
using System.Threading.Tasks;
using Fiorello_MVC.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_MVC.Areas.Admin.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menus = new List<MenuViewModel>
            {
                new MenuViewModel
                {
                    Name = "Dashboard",
                    Icon = "fas fa-tachometer-alt",
                    Controller = "Dashboard",
                    Action = "Index"
                },
                new MenuViewModel
                {
                    Name = "Sliders",
                    Icon = "fas fa-layer-group",
                    Controller = "Slider",
                    Action = "Index"
                },
                new MenuViewModel
                {
                    Name = "Categories",
                    Icon = "fas fa-bars",
                    Controller = "Category",
                    Action = "Index"
                },
                new MenuViewModel
                {
                    Name = "Products",
                    Icon = "fas fa-layer-group",
                    Controller = "Product",
                    Action = "Index"
                },
                new MenuViewModel
                {
                    Name = "Experts",
                    Icon = "fas fa-users",
                    Controller = "Expert",
                    Action = "Index"
                },
                new MenuViewModel
                {
                    Name = "Testimonials",
                    Icon = "fas fa-comment-dots",
                    Controller = "Testimonial",
                    Action = "Index"
                },
                new MenuViewModel
                {
                    Name = "Settings",
                    Icon = "fas fa-fw fa-cog",
                    Controller = "Setting",
                    Action = "Index"
                }
            };

            return View(menus);
        }
    }
}