using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Utilities.File.Validations;

namespace Fiorello_MVC.Areas.Admin.ViewModels
{
    public class SliderViewModel
    {
        [Required(ErrorMessage = "Please select a file.")]
        [MaxFileSize(200 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        public IFormFile Photo { get; set; }

        public string CurrentPhoto { get; set; }
    }
}