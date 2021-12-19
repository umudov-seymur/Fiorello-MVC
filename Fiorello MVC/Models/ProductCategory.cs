using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fiorello_MVC.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public ICollection<Product> Products;
    }
}
