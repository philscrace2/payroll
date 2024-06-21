using PayrollEntities.paymenttype;

namespace PayrollDBAdapterInMemory.entity
{
    public class SalariedPaymentTypeImpl : SalariedPaymentType
    {
        private int? monthlySalary;

        public SalariedPaymentTypeImpl(int? monthlySalary)
        {
            this.monthlySalary = monthlySalary;
        }


        public override int? getMonthlySalary()
        {
            return monthlySalary;
        }


        public override void setMonthlySalary(int? monthlySalary)
        {
            this.monthlySalary = monthlySalary;
        }

    }
}