using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_MVC.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public TestimonialAuthor Author { get; set; }
        public string Description { get; set; }
    }
}
