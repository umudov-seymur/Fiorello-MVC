using System.Collections.Generic;
using System.Threading.Tasks;
using Fiorello_MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_MVC.Areas.Admin.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menus = new List<MenuItem>
            {
                new MenuItem
                {
                    Name = "Dashboard",
                    Icon = "fas fa-tachometer-alt",
                    Controller = "Dashboard",
                    Action = "Index"
                },
                new MenuItem
                {
                    Name = "Sliders",
                    Icon = "fas fa-layer-group",
                    Controller = "",
                    Action = "Index"
                },
                new MenuItem
                {
                    Name = "Categories",
                    Icon = "fas fa-bars",
                    Controller = "Category",
                    Action = "Index"
                },
                new MenuItem
                {
                    Name = "Products",
                    Icon = "fas fa-layer-group",
                    Controller = "Product",
                    Action = "Index"
                },
                new MenuItem
                {
                    Name = "Products",
                    Icon = "fas fa-shopping-cart",
                    Controller = "Product",
                    Action = "Index"
                },
                new MenuItem
                {
                    Name = "Experts",
                    Icon = "fas fa-users",
                    Controller = "Expert",
                    Action = "Index"
                },
                new MenuItem
                {
                    Name = "Testimonials",
                    Icon = "fas fa-comment-dots",
                    Controller = "Testimonial",
                    Action = "Index"
                },
                new MenuItem
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