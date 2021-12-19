using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fiorello_MVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public ProductCategory Category { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
