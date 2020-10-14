using System.ComponentModel.DataAnnotations;
namespace form_with_validation
{
    public class NoZNamesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(((string)value).ToLower()[0] == 'z')
                return new ValidationResult("Please do not user name that starts with Z");
            return ValidationResult.Success;
        }
    }
}