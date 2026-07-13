using System.ComponentModel.DataAnnotations;

namespace EWSApi.Utils.Validation
{
    public class RequiredIfAttribute : ValidationAttribute
    {
        private readonly string _dependentProperty;
        private readonly object? _targetValue;

        public RequiredIfAttribute(string dependentProperty, object? targetValue)
        {
            _dependentProperty = dependentProperty;
            _targetValue = targetValue;
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

            // Nëse vlera e fushës varëse është e barabartë me target-in, atëherë fusha jonë bëhet e detyrueshme
            bool isTargetMatch = (dependentValue == null && _targetValue == null)
                || (dependentValue != null && dependentValue.Equals(_targetValue));

            if (isTargetMatch)
            {
                if (value == null || (value is string str && string.IsNullOrWhiteSpace(str)))
                {
                    return new ValidationResult(
                        ErrorMessage ?? $"Fusha '{validationContext.MemberName}' është e detyrueshme.",
                        new[] { validationContext.MemberName! });
                }
            }

            return ValidationResult.Success;
        }
    }
}
