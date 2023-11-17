namespace PayrollPorts.primaryAdminUseCase.request
{
    public class GetEmployeeRequest : Request
    {

        public int employeeId;

        public GetEmployeeRequest(int employeeId)
        {
            this.employeeId = employeeId;
        }
    }

}