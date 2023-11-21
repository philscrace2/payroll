namespace PayrollPorts.primaryAdminUseCase.request.addemployee
{
    public class AddEmployeeRequest : Request
    {
        public int? employeeId;
        public String name;
        public String address;

        public AddEmployeeRequest()
        {
        }
        public AddEmployeeRequest(int? employeeId, String name, String address)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.address = address;
        }
    }
}