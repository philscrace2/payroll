namespace PayrollPorts.primaryAdminUseCase.request
{
    public class AddServiceChargeRequest : Request
    {
        public readonly int unionMemberId;
        public readonly DateTime date;
        public readonly int amount;

        public AddServiceChargeRequest(int unionMemberId, DateTime date, int amount)
        {
            this.unionMemberId = unionMemberId;
            this.date = date;
            this.amount = amount;
        }
    }
}


