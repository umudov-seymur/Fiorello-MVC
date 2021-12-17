using System;

namespace Fiorello_MVC.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
