using System.ComponentModel.DataAnnotations;

namespace Fiorello_MVC.Areas.Admin.ViewModels.Auth
{
    public class RegisterViewModel
    {
        [Required, DataType(DataType.Text), MaxLength(50)]
        public string FirstName { get; set; }
 
        [Required, DataType(DataType.Text), MaxLength(50)]
        public string LastName { get; set; }
        
        [Required, DataType(DataType.Text)]
        public string Username { get; set; }
        
        [Required, DataType(DataType.EmailAddress), EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}