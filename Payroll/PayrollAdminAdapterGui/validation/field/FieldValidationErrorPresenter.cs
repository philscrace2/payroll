using PayrollAdminAdapterGui.formatters.controller.msg;

namespace PayrollAdminAdapterGui.validation.field
{
    using System.Linq;

    public class FieldValidationErrorPresenter
    {
        private FieldValidatorErrorFormatter fieldValidatorErrorFormatter;

        public FieldValidationErrorPresenter(FieldValidatorErrorFormatter fieldValidatorErrorFormatter)
        {
            this.fieldValidatorErrorFormatter = fieldValidatorErrorFormatter;
        }

        public ValidationErrorMessagesModel Present(FieldValidatorException e)
        {
            var errorMessages = e.fieldValidatorErrors
                .Select(fieldValidatorError => fieldValidatorErrorFormatter.Format(fieldValidatorError))
                .ToList();

            return new ValidationErrorMessagesModel(errorMessages);
        }
    }


}