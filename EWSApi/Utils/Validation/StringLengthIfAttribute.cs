using System.ComponentModel.DataAnnotations;

namespace EWSApi.Utils.Validation
{
    public class StringLengthIfAttribute : ValidationAttribute
    {
        private readonly string _dependentProperty;
        private readonly object? _targetValue;
        private readonly int _minLength;
        private readonly int _maxLength;

        public StringLengthIfAttribute(string dependentProperty, object? targetValue, int minLength, int maxLength)
        {
            _dependentProperty = dependentProperty;
            _targetValue = targetValue;
            _minLength = minLength;
            _maxLength = maxLength;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var containerType = validationContext.ObjectInstance.GetType();
            var dependentPropertyInfo = containerType.GetProperty(_dependentProperty);

            if (dependentPropertyInfo == null)
            {
                return new ValidationResult(
                    $"Fusha '{_dependentProperty}' nuk ekziston.",
                    new[] { validationContext.MemberName! });
            }

            var dependentValue = dependentPropertyInfo.GetValue(validationContext.ObjectInstance, null);

            bool isTargetMatch = (dependentValue == null && _targetValue == null)
                || (dependentValue != null && dependentValue.Equals(_targetValue));

            // Nëse kushti (Foreign == false) nuk plotësohet, mos e kontrollo gjatësinë fare
            if (!isTargetMatch)
            {
                return ValidationResult.Success;
            }

            // Kushti plotësohet -> kontrollo gjatësinë
            var stringValue = value as string ?? string.Empty;

            if (stringValue.Length < _minLength || stringValue.Length > _maxLength)
            {
                return new ValidationResult(
                    ErrorMessage ?? $"Fusha '{validationContext.MemberName}' duhet të ketë {_minLength} karaktere.",
                    new[] { validationContext.MemberName! });
            }

            return ValidationResult.Success;
        }
    }
}