using PayrollAdminAdapterGui.validation.field;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.validator.paymentmethod
{
    public class DirectPaymentMethodValidator : AbstractFieldsValidator<DirectPaymentMethod>
    {
        protected override void AddErrors(DirectPaymentMethod model)
        {
            //if (model.AccountNumber == "")
                AddFieldValidatorError("accountNumber", FieldValidatorErrorType.EMPTY_STRING);
        }

    }

}