namespace PayrollPorts.primaryAdminUseCase.request.changemployee
{
    public class ChangeEmployeeRequest : Request
    {

        public int employeeId;

        public ChangeEmployeeRequest(int employeeId)
        {
            this.employeeId = employeeId;
        }
    }

}