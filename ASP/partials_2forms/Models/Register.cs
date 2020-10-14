using System.ComponentModel.DataAnnotations;
namespace partials_2forms.Models
{
    public class Register
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name :")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name :")]
        public string LastName { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email :")]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password :")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password need to match up with Confirm Password")]
        [Display(Name = "Confirm Password :")]
        public string Confirm_Password { get; set; }
    }
}