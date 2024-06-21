namespace PayrollPorts.primaryAdminUseCase.request.changemployee
{
    public class ChangeEmployeeNameRequest : ChangeEmployeeRequest
    {

        public String newName;

        public ChangeEmployeeNameRequest(int? employeeId, String newName) : base(employeeId)
        {
            this.newName = newName;
        }
    }
}