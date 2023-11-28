using PayrollEntities.paymenttype;

namespace PayrollDBAdapterInMemory.entity
{

    public class CommissionedPaymentTypeImpl : CommissionedPaymentType
    {
        private int biWeeklyBaseSalary;
        private double commissionRate;

        private Dictionary<DateTime, SalesReceipt> salesReceiptsByDate = new Dictionary<DateTime, SalesReceipt>();

        public CommissionedPaymentTypeImpl(int biWeeklyBaseSalary, double commissionRate)
        {
            this.biWeeklyBaseSalary = biWeeklyBaseSalary;
            this.commissionRate = commissionRate;
        }


        public override int getBiWeeklyBaseSalary()
        {
            return biWeeklyBaseSalary;
        }


        public override double getCommissionRate()
        {
            return commissionRate;
        }

        public override void addSalesReceipt(SalesReceipt salesReceipt)
        {
            salesReceiptsByDate.Add(salesReceipt.getDate(), salesReceipt);
        }

        public override List<SalesReceipt> getSalesReceiptsIn(PayrollEntities.DateInterval dateInterval)
        {
            return salesReceiptsByDate
                .Where(entry => dateInterval.isBetweenInclusive(entry.Key))
                .Select(entry => entry.Value)
                .ToList();
        }

    }

}