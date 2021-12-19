using System;
using System.ComponentModel.DataAnnotations;

namespace Fiorello_MVC.Models
{
    public class ExpertPosition
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
