using PayrollEntities.paymenttype;

namespace PayrollDBAdapterInMemory.entity
{
    public class TimeCardImpl : TimeCard
    {
        private DateTime date;
        private int? workingHourQty;

        public TimeCardImpl(DateTime date, int? workingHoursQty)
        {
            this.date = date;
            this.workingHourQty = workingHoursQty;
        }

        public override DateTime getDate()
        {
            return date;
        }

        public override void setDate(DateTime date)
        {
            this.date = date;
        }

        public override int? getWorkingHourQty()
        {
            return workingHourQty;
        }

        public override void setWorkingHourQty(int workingHourQty)
        {
            this.workingHourQty = workingHourQty;
        }



    }

}