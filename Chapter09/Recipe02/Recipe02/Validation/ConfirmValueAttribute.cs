using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Recipe02.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ConfirmValueAttribute : ValidationAttribute, IClientModelValidator
    {
        private object _expectedValue;
        public ConfirmValueAttribute(object expectedValue)
        {
            _expectedValue = expectedValue;
            
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            
            if(Equals(value, _expectedValue))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage);
            
        }
        public void AddValidation(ClientModelValidationContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-confirmvalue", ErrorMessage);
            context.Attributes.Add("data-val-confirmvalue-expectedvalue", _expectedValue.ToString());
        }
    }
}
