
using System.ComponentModel.DataAnnotations;

namespace MVC5FormsAuthentication.Models
{
    public class User
    {   
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public string Roles { get; set; }
    }
}