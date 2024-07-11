using PayrollAdminAdapterGui.validation.field;
using PayrollEntities.paymentmethod;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.validator.paymentmethod
{
    public class PaymentMethodFieldsValidatorFactory : PaymentMethodVisitor<List<FieldValidatorError>>
    {
        public List<FieldValidatorError> visit(PaymasterPaymentMethod paymentMethod)
        {
            return new PaymasterPaymentMethodValidator().GetErrors(paymentMethod);
        }

        public List<FieldValidatorError> visit(DirectPaymentMethod paymentMethod)
        {
            return new DirectPaymentMethodValidator().GetErrors(paymentMethod);
        }

    }


}