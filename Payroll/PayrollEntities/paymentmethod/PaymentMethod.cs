namespace PayrollEntities.paymentmethod
{
    public interface PaymentMethod
    {
        public abstract T Accept<T>(IPaymentMethodVisitor<T> visitor);

        public interface IPaymentMethodVisitor<T>
        {
            public T visit(PaymasterPaymentMethod paymasterPaymentMethod);
            public T visit(DirectPaymentMethod directPaymentMethod);
        }
    }
    public interface PaymentMethodFactory
    {
        PaymentMethod paymasterPaymentMethod();
        PaymentMethod directPaymentMethod(String accountNumber);
    }


}
