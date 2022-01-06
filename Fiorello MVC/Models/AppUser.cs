using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace Fiorello_MVC.Models
{
    public class AppUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DefaultValue(false)]
        public bool IsActivated { get; set; }
    }
}