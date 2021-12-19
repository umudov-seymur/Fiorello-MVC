using System;

namespace Fiorello_MVC.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
