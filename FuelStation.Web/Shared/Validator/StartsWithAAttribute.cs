using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.StartsWithAValidator {
    public class StartsWithAAttribute : ValidationAttribute {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext) {
            string errorMessage = "The card number must start with the letter A";
            if (value != null) {
                string? stringValue = value.ToString();
                if (stringValue != null) {
                    if (stringValue.StartsWith("A")) {
                        return ValidationResult.Success!;
                    }
                }
            }
            return new ValidationResult(ErrorMessage ?? errorMessage);
        }
    }
}
