using System.ComponentModel.DataAnnotations;
using System;
namespace form_with_validation
{
    public class PastDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime today = DateTime.Now;
            if((DateTime)value > today)
                return new ValidationResult("You can't be from the future, please select a different date");
            return ValidationResult.Success;
        }
    }
}