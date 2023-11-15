namespace PayrollEntities.paymenttype
{
    public abstract class SalariedPaymentType : StrictIntervalPaymentType
    {
        public abstract int getMonthlySalary();
        public abstract void setMonthlySalary(int monthlySalary);

        public override T accept<T>(PaymentTypeVisitor<T> visitor)
        {
            return visitor.visit(this);
        }
        protected override int calculateAmountOnValidatedInterval(DateInterval dateInterval)
        {
            return getMonthlySalary();
        }


        protected override bool isValidInterval(DateInterval dateInterval)
        {
            return IsFullMonthInterval(dateInterval);
        }

        private static bool IsFullMonthInterval(DateInterval dateInterval)
        {
            bool fromIsFirstDayOfMonth = dateInterval.from.Day == 1;
            bool toIsLastDayOfMonth = dateInterval.to.Day == DateTime.DaysInMonth(dateInterval.to.Year, dateInterval.to.Month);
            return fromIsFirstDayOfMonth && toIsLastDayOfMonth;
        }


    }


}

