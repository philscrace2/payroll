namespace PayrollPorts.primaryAdminUseCase.response
{
    public class PaymentFulfillResponse : Response
    {

        public int? payCheckCount;
        public int? totalNetAmount;

        public PaymentFulfillResponse(int? payCheckCount, int? totalGrossAmount)
        {
            this.payCheckCount = payCheckCount;
            this.totalNetAmount = totalGrossAmount;
        }
    }


}