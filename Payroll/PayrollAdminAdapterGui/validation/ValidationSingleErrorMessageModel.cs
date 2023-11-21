namespace PayrollAdminAdapterGui.validation
{
    public class ValidationSingleErrorMessageModel : ValidationErrorMessagesModel
    {
        public ValidationSingleErrorMessageModel(String validationErrorMessage) : base(new List<string>() { validationErrorMessage })
        {

        }

    }

}