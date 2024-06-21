namespace PayrollEntities.paymenttype
{
    public abstract class CommissionedPaymentType : StrictIntervalPaymentType
    {
        private static readonly int? TWO_WEEK_DAYS = 14;

        public abstract int? getBiWeeklyBaseSalary();
        public abstract double getCommissionRate();

        public abstract void addSalesReceipt(SalesReceipt salesReceipt);
        public abstract List<SalesReceipt> getSalesReceiptsIn(DateInterval dateInterval);


        public override T accept<T>(PaymentTypeVisitor<T> visitor)
        {
            return visitor.visit(this);
        }


        protected override int? calculateAmountOnValidatedInterval(DateInterval dateInterval)
        {
            return getBiWeeklyBaseSalary() + CalculateCommissionAmount(dateInterval);
        }

        private int? CalculateCommissionAmount(DateInterval dateInterval)
        {
            int? sumAmount = 0;
            IEnumerable<SalesReceipt> salesReceipts = getSalesReceiptsIn(dateInterval);
            foreach (SalesReceipt salesReceipt in salesReceipts)
            {
                sumAmount += calculateCommissionAmount(salesReceipt);
            }
            return sumAmount;
        }


        private int? calculateCommissionAmount(SalesReceipt salesReceipt)
        {
            return (int?)(salesReceipt.getAmount() * getCommissionRate());
        }


        protected override bool isValidInterval(DateInterval dateInterval)
        {
            return isBiWeeklyInterval(dateInterval);
        }

        private bool isBiWeeklyInterval(DateInterval dateInterval)
        {
            TimeSpan duration = dateInterval.to - dateInterval.from;
            long daysBetween = (long)duration.TotalDays;
            long daysTotal = daysBetween + 1; // Adding 1 because the interval is inclusive
            return daysTotal == TWO_WEEK_DAYS;
        }
    }

}


