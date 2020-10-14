using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System;
namespace form_with_validation.Models
{
    public class User
    {
        [Required]
        [MinLength(3)]
        [NoZNames]
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }        
        
        [Required]
        [MinLength(3)]
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }

        [Required]
        [Range(0,150)]
        [Display(Name = "Age: ")]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }

        [Required]
        [PastDate]
        [DataType(DataType.Date)]
        [Display(Name = "Birthday: ")]
        public DateTime Birthday { get; set; }
    }
}