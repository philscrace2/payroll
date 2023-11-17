namespace PayrollPorts.primaryAdminUseCase.request
{
    public class PaymentFulfillRequest : Request
    {

        public DateTime payDate;

        public PaymentFulfillRequest(DateTime payDate)
        {
            this.payDate = payDate;
        }

    }

}

