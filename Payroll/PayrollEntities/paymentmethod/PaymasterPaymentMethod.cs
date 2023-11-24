

namespace PayrollEntities.paymentmethod
{
    public abstract class PaymasterPaymentMethod : PaymentMethod
    {
        public T Accept<T>(PaymentMethod.IPaymentMethodVisitor<T> visitor)
        {
            return visitor.visit(this);
        }
    }
}