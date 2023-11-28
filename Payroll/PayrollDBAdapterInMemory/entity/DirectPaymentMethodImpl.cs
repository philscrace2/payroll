using PayrollEntities.paymentmethod;

namespace PayrollDBAdapterInMemory.entity
{
    public class DirectPaymentMethodImpl : DirectPaymentMethod
    {

        private String accountNumber;

        public DirectPaymentMethodImpl(String accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public override string getAccountNumber()
        {
            return accountNumber;
        }


        public override void setAccountNumber(String accountNumber)
        {
            this.accountNumber = accountNumber;
        }

    }
}