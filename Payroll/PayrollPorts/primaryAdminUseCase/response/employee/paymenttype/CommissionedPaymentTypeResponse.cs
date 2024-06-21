
namespace PayrollPorts.primaryAdminUseCase.response.employee.paymenttype
{
    public class CommissionedPaymentTypeResponse : PaymentTypeResponse
    {
        public int? biWeeklyBaseSalary;
        public double commissionRate;

        public CommissionedPaymentTypeResponse(int? biWeeklyBaseSalary, double commissionRate)
        {
            this.biWeeklyBaseSalary = biWeeklyBaseSalary;
            this.commissionRate = commissionRate;
        }

        public override T accept<T>(PaymentTypeResponseVisitor<T> visitor)
        {
            return visitor.visit(this);
        }

    }

}