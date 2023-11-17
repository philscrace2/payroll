namespace PayrollEntities.paymentschedule
{
    public class MonthlyPaymentSchedule : PaymentSchedule
    {

        public override bool isPayDate(DateTime date)
        {
            return isLastDayOfMonth(date);
        }


        protected override DateInterval getPayIntervalForValidatedPayDate(DateTime payday)
        {
            return DateInterval.of(
                    GetFirstDayOfMonth(payday),
                    GetLastDayOfMonth(payday));
        }


        public override DateTime getSameOrNextPayDate(DateTime referenceDate)
        {
            return GetLastDayOfMonth(referenceDate);
        }

        private bool isLastDayOfMonth(DateTime date)
        {
            return GetLastDayOfMonth(date).Equals(date);
        }

        private DateTime GetFirstDayOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        private DateTime GetLastDayOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }

    }
}
