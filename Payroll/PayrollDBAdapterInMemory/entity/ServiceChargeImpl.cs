using PayrollEntities.affiliation;

namespace PayrollDBAdapterInMemory.entity
{
    public class ServiceChargeImpl : ServiceCharge
    {
        private DateTime date;
        private int? amount;

        public ServiceChargeImpl(DateTime date, int? amount)
        {
            this.date = date;
            this.amount = amount;
        }

        public int? getAmount()
        {
            return amount;
        }


        public DateTime getDate()
        {
            return date;
        }


        public void setAmount(int? amount)
        {
            this.amount = amount;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }
    }
}

