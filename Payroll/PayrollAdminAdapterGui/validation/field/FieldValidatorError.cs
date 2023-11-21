namespace PayrollAdminAdapterGui.validation.field
{
    public class FieldValidatorError
    {
        public String fieldName;
        public FieldValidatorErrorType type;



        public FieldValidatorError(String fieldName, FieldValidatorErrorType errorType)
        {
            this.fieldName = fieldName;
            type = errorType;
        }
    }

    public enum FieldValidatorErrorType
    {
        REQUIRED,
        EMPTY_STRING
    }

}