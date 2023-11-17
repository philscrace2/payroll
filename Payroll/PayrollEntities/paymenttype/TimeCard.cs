namespace PayrollEntities.paymenttype
{
    public abstract class TimeCard
    {

        public abstract DateTime getDate();
        public abstract int getWorkingHourQty();

        public abstract void setDate(DateTime date);
        public abstract void setWorkingHourQty(int workingHourQty);

    }

    public interface TimeCardFactory
    {
        TimeCard timeCard(DateTime date, int workingHoursQty);
    }



}


