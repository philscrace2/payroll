namespace PayrollPorts.primaryAdminUseCase.response.employee.paymenttype
{
    public class HourlyPaymentTypeResponse : PaymentTypeResponse
    {

        public int hourlyWage;

        public HourlyPaymentTypeResponse(int hourlyWage)
        {
            this.hourlyWage = hourlyWage;
        }


        public override T accept<T>(PaymentTypeResponseVisitor<T> visitor)
        {
            return visitor.visit(this);
        }

    }

}