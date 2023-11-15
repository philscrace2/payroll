namespace PayrollEntities.paymentmethod
{

    public abstract class DirectPaymentMethod : PaymentMethod
    {
        public T Accept<T>(IPaymentMethodVisitor<T> visitor)
        {
            return visitor.visit(this);
        }

        public abstract String getAccountNumber();
        public abstract void setAccountNumber(String accountNumber);
    } 

}


