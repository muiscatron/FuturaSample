using System.Windows.Controls;

namespace NumericInput
{
    public class UserInputValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return new ValidationResult(false, "A value is required!");
            }
            int result;
            if (int.TryParse(value.ToString(), out result))
            {
                return new ValidationResult(true, null);
            }
            return new ValidationResult(false, "A number is required!");
        }
    }
}
