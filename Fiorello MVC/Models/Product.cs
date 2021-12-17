using System;
using System.ComponentModel.DataAnnotations;

namespace Fiorello_MVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public ProductCategory Category { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
