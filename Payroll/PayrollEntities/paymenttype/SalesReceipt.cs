namespace PayrollEntities.paymenttype
{
    public abstract class SalesReceipt
    {

        public abstract int getAmount();
        public abstract DateTime getDate();

        public abstract void setAmount(int amount);
        public abstract void setDate(DateTime date);

        public interface SalesReceiptFactory
        {
            SalesReceipt salesReceipt(DateTime date, int amount);
        }

    }


}


