using Fiorello_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_MVC.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ExpertPosition> ExpertPositions { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TestimonialAuthor> TestimonialAuthors { get; set; }
        public DbSet<Setting> Settings { get; set; }
    }
}
