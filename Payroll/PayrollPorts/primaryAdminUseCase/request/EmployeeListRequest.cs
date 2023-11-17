namespace PayrollPorts.primaryAdminUseCase.request
{
    public class EmployeeListRequest : Request
    {

        public readonly DateTime currentDate;

        public EmployeeListRequest(DateTime currentDate)
        {
            this.currentDate = currentDate;
        }
    }
}


