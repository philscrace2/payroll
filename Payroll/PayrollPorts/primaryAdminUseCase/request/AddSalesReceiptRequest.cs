namespace PayrollPorts.primaryAdminUseCase.request
{
    public class AddSalesReceiptRequest : Request
    {
        public readonly int employeeId;
        public readonly DateTime date;
        public readonly int amount;

        public AddSalesReceiptRequest(int employeeId, DateTime date, int amount)
        {
            this.employeeId = employeeId;
            this.date = date;
            this.amount = amount;
        }
    }

}


