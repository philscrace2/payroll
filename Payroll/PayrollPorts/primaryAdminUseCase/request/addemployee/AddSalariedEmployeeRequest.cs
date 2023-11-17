namespace PayrollPorts.primaryAdminUseCase.request.addemployee
{
    public class AddSalariedEmployeeRequest : AddEmployeeRequest
    {
        public int monthlySalary;

        public AddSalariedEmployeeRequest()
        {
        }
        public AddSalariedEmployeeRequest(int employeeId, String name, String address, int monthlySalary) : base(employeeId, name, address)
        {
            this.monthlySalary = monthlySalary;
        }


    }
}

