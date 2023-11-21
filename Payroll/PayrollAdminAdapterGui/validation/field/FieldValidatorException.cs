namespace PayrollAdminAdapterGui.validation.field
{
    public class FieldValidatorException : Exception
    {

        public readonly List<FieldValidatorError> fieldValidatorErrors;
        public FieldValidatorException(List<FieldValidatorError> fieldValidatorErrors)
        {
            this.fieldValidatorErrors = fieldValidatorErrors;
        }

    }


}