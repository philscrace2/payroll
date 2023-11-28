using PayrollEntities.paymenttype;

namespace PayrollDBAdapterInMemory.entity
{
    public class SalesReceiptImpl : SalesReceipt
    {

        private DateTime date;
        private int amount;

        public SalesReceiptImpl(DateTime date, int amount)
        {
            this.date = date;
            this.amount = amount;
        }

        public override DateTime getDate()
        {
            return date;
        }

        public override void setDate(DateTime date)
        {
            this.date = date;
        }

        public override int getAmount()
        {
            return amount;
        }

        public override void setAmount(int amount)
        {
            this.amount = amount;
        }


    }
}