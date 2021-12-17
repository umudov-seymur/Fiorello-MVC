using System;
using System.ComponentModel.DataAnnotations;

namespace Fiorello_MVC.Models
{
    public class Expert
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }   
        public int PositionId { get; set; }
        public ExpertPosition Position { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
