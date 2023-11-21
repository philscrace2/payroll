namespace PayrollAdminAdapterGui.Formatters.Common
{
    public class FieldValidatorErrorFormatter
    {
        public static readonly Dictionary<Type, string> MessagesByFieldValidatorErrorType = new Dictionary<Type, string>
        {
            { Type.Required, "{0} is missing" },
            { Type.EmptyString, "{0} should not be empty" }
        };

        public string Format(FieldValidatorError e)
        {
            if (MessagesByFieldValidatorErrorType.TryGetValue(e.Type, out var message))
            {
                return string.Format(message, e.FieldName);
            }

            throw new InvalidOperationException("No formatter available for given field validator error type.");
        }
    }

    // Assuming the enumeration 'Type' is defined somewhere else in your codebase.
    public enum Type
    {
        Required,
        EmptyString
        // Other error types can be added here
    }

    // Assuming the 'FieldValidatorError' class is defined somewhere else in your codebase.
    public class FieldValidatorError
    {
        public Type Type { get; set; }
        public string FieldName { get; set; }

        // Other properties and methods can be defined here
    }
}
