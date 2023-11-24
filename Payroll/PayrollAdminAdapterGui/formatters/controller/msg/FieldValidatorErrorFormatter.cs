using PayrollAdminAdapterGui.validation.field;

namespace PayrollAdminAdapterGui.formatters.controller.msg
{
    public class FieldValidatorErrorFormatter
    {
        public static readonly Dictionary<FieldValidatorErrorType, string> MessagesByFieldValidatorErrorType = new Dictionary<FieldValidatorErrorType, string>
        {
            { FieldValidatorErrorType.REQUIRED, "{0} is missing" },
            { FieldValidatorErrorType.EMPTY_STRING, "{0} should not be empty" }
        };

        public string Format(FieldValidatorError e)
        {
            if (MessagesByFieldValidatorErrorType.TryGetValue(e.type, out var message))
            {
                return string.Format(message, e.fieldName);
            }

            throw new InvalidOperationException("No formatter available for given field validator error type.");
        }
    }

    //// Assuming the enumeration 'Type' is defined somewhere else in your codebase.
    //public enum Type
    //{
    //    REQUIRED,
    //    EMPTY_STRING
    //    // Other error types can be added here
    //}


}
