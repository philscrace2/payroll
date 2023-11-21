namespace PayrollAdminAdapterGui.validation.field
{
    public abstract class AbstractFieldsValidator<T>
    {
        private List<FieldValidatorError> fieldValidatorErrors;

        public List<FieldValidatorError> GetErrors(T model)
        {
            fieldValidatorErrors = new List<FieldValidatorError>();
            AddErrors(model);
            return fieldValidatorErrors;
        }

        protected abstract void AddErrors(T model);

        protected void AddFieldValidatorError(string fieldName, FieldValidatorErrorType type)
        {
            fieldValidatorErrors.Add(new FieldValidatorError(fieldName, type));
        }

        protected void AddFieldValidatorErrors(IEnumerable<FieldValidatorError> fieldValidatorErrors)
        {
            this.fieldValidatorErrors.AddRange(fieldValidatorErrors);
        }
    }

}