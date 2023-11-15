

namespace PayrollEntities.paymentmethod
{
    public abstract class PaymasterPaymentMethod : PaymentMethod
    {
        public  T Accept<T>(IPaymentMethodVisitor<T> visitor)
        {
            return visitor.visit(this);
        }        
    }
}