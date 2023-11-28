namespace PayrollEntities.paymenttype
{
    public abstract class PaymentType
    {
        public abstract int? calculateAmount(DateInterval payInterval);

        public abstract T accept<T>(PaymentTypeVisitor<T> visitor);
    }

    public interface PaymentTypeFactory
    {
        SalariedPaymentType salariedPaymentType(int monthlySalary);
        HourlyPaymentType hourlyPaymentType(int hourlyWage);
        CommissionedPaymentType commissionedPaymentType(int biWeeklyBaseSalary, double commissionRate);
    }

    public interface PaymentTypeVisitor<T>
    {
        public T visit(CommissionedPaymentType commissionedPaymentType);
        public T visit(SalariedPaymentType salariedPaymentType);
        public T visit(HourlyPaymentType hourlyPaymentType);
    }

}


