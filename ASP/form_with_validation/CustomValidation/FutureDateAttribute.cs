using System.ComponentModel.DataAnnotations;
using System;
namespace form_with_validation
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime today = System.DateTime.Now;
            if((DateTime)value < today)
                return new ValidationResult("Please only enter future date");
            return ValidationResult.Success;
        }
    }
}