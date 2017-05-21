using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Recipe02.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ConfirmValueAttribute : ValidationAttribute, IClientModelValidator
    {
        private object _expectedValue;
        public ConfirmValueAttribute(object expectedValue)
        {
            _expectedValue = expectedValue;
            
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            return Equals(value, _expectedValue);
            
        }
        public void AddValidation(ClientModelValidationContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (string.IsNullOrWhiteSpace(ErrorMessage))
            {
                ErrorMessage = string.Format("{0} must be true.", context.ModelMetadata.DisplayName);
            }
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-confirmvalue", ErrorMessage);
            context.Attributes.Add("data-val-confirmvalue-expectedvalue", _expectedValue.ToString());
        }
    }
}
