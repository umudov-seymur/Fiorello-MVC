using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fiorello_MVC.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required]
        public string Image { get; set; }
        [DefaultValue(false)]
        public bool IsMain { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
