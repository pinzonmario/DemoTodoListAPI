using System.ComponentModel.DataAnnotations;

namespace DemoTodoListAPI.Validations
{
    public class FirstCapitalLetterAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            string firstLetter = value.ToString()![0].ToString();

            if (firstLetter != firstLetter.ToUpper())
            {
                return new ValidationResult("First letter must be capitalized");
            }

            return ValidationResult.Success;
        }
    }
}
