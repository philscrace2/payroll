namespace PayrollPorts.primaryAdminUseCase.request.hourly
{
    public class AddTimeCardRequest : AbstractTimeCardRequest
    {
        public readonly DateTime date;
        public readonly int? workingHoursQty;

        public AddTimeCardRequest(int employeeId, DateTime date, int? workingHoursQty) : base(employeeId)
        {
            this.date = date;
            this.workingHoursQty = workingHoursQty;
        }
    }


}