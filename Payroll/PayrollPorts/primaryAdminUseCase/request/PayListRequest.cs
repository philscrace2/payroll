namespace PayrollPorts.primaryAdminUseCase.request
{
    public class PayListRequest : Request
    {

        public DateTime payDate;

        public PayListRequest(DateTime payDate)
        {
            this.payDate = payDate;
        }
    }


}

