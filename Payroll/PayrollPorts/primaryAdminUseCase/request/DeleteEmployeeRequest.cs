namespace PayrollPorts.primaryAdminUseCase.request
{
    public class DeleteEmployeeRequest : Request
    {

        public int? employeeId;

        public DeleteEmployeeRequest(int? employeeId)
        {
            this.employeeId = employeeId;
        }
    }

}