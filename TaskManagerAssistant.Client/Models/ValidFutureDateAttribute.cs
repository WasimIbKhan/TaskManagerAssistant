using System;
using System.ComponentModel.DataAnnotations;

public class ValidFutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime dateTimeValue)
        {
            if (dateTimeValue < DateTime.Now)
            {
                return new ValidationResult("Due date must be in the future.");
            }
        }
        else
        {
            return new ValidationResult("Invalid date format.");
        }
        return ValidationResult.Success;
    }
}
