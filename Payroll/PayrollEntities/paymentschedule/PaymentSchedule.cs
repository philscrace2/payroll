namespace PayrollEntities.paymentschedule
{
    public abstract class PaymentSchedule
    {

        public abstract bool isPayDate(DateTime date);

        /** @throws NotAPaydayException	**/
        public DateInterval getPayInterval(DateTime payDate)
        {
            return getPayIntervalForValidatedPayDate(validatePayDate(payDate));
        }

        private DateTime validatePayDate(DateTime date)
        {
            if (!isPayDate(date))
                throw new NotAPaydayException();
            return date;
        }

        protected abstract DateInterval getPayIntervalForValidatedPayDate(DateTime payDate);

        public abstract DateTime getSameOrNextPayDate(DateTime referenceDate);
    }



    public class NotAPaydayException : Exception
    {
    }

    public interface PaymentScheduleFactory
    {
        PaymentSchedule monthlyPaymentSchedule();
        WeeklyPaymentSchedule weeklyPaymentSchedule();
        BiWeeklyPaymentSchedule biWeeklyPaymentSchedule();
    }

}

