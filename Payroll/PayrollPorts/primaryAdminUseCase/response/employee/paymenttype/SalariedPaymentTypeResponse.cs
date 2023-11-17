namespace PayrollPorts.primaryAdminUseCase.response.employee.paymenttype
{
    public class SalariedPaymentTypeResponse : PaymentTypeResponse
    {

        public int monthlySalary;

        public SalariedPaymentTypeResponse(int monthlySalary)
        {
            this.monthlySalary = monthlySalary;
        }


        public override T accept<T>(PaymentTypeResponseVisitor<T> visitor)
        {
            return visitor.visit(this);
        }

    }

}