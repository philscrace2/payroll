namespace PayrollPorts.primaryAdminUseCase.request.hourly
{
    public class AbstractTimeCardRequest : Request
    {
        public readonly int? employeeId;

        public AbstractTimeCardRequest(int? employeeId)
        {
            this.employeeId = employeeId;
        }

    }

}