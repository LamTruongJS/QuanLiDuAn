using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Helper.Validation
{
    public class PatternTextAttribute : ValidationAttribute, IClientModelValidator
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string text = value?.ToString();
            if(IsContainUppercase(text) && IsContainDigit(text))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage ?? "The " + validationContext.DisplayName + "have to contain uppercase and digit.");
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-patterntext", ErrorMessage ?? "The " + context.ModelMetadata.DisplayName + " have to contain uppercase and digit.");
        }

        #region Logic
        private bool IsContainUppercase(string text)
        {
            return text.Any(c => char.IsUpper(c));
        }
        private bool IsContainDigit(string text)
        {
            return text.Any(c => char.IsDigit(c));
        }
        private bool IsContainNonAlphanumeric(string text)
        {
            return !text.All(c => char.IsLetterOrDigit(c));
        }
        #endregion
    }
}
