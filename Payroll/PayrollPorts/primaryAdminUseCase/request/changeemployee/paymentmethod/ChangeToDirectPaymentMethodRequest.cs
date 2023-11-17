namespace PayrollPorts.primaryAdminUseCase.request.changemployee.paymentmethod
{
    public class ChangeToDirectPaymentMethodRequest : ChangeEmployeeRequest
    {

        public String accountNumber;

        public ChangeToDirectPaymentMethodRequest(int employeeId, String accountNumber) : base(employeeId)
        {
            this.accountNumber = accountNumber;
        }

    }

}