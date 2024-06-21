namespace PayrollPorts.primaryAdminUseCase.request.hourly
{
    public class UpdateTimeCardRequest : AbstractTimeCardRequest
    {

        public readonly DateTime date;
        public readonly int? workingHoursQty;

        public UpdateTimeCardRequest(int? employeeId, DateTime date, int? workingHoursQty) : base(employeeId)
        {
            this.date = date;
            this.workingHoursQty = workingHoursQty;
        }
    }


}