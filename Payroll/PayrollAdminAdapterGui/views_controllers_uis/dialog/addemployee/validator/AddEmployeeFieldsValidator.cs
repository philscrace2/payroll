using PayrollAdminAdapterGui.validation.field;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.validator
{
    public abstract class AddEmployeeFieldsValidator<T> : AbstractFieldsValidator<T> where T : EmployeeViewModel
    {
        protected override void AddErrors(T model)
        {
            AddBaseErrors(model);
            AddPaymentMethodErrors(model);
            AddSubTypeErrors(model);
        }

        private void AddBaseErrors(T model)
        {
            if (!model.EmployeeId.HasValue)
                AddFieldValidatorError("id", FieldValidatorErrorType.REQUIRED);
            if (string.IsNullOrEmpty(model.Name))
                AddFieldValidatorError("name", FieldValidatorErrorType.EMPTY_STRING);
        }

        private void AddPaymentMethodErrors(T model)
        {
            //AddFieldValidatorErrors(model.PaymentMethod.Accept<PaymentMethodFieldsValidatorFactory>(new PaymentMethodFieldsValidatorFactory()));
        }

        protected abstract void AddSubTypeErrors(T model);
    }


}