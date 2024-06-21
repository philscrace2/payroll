namespace PayrollPorts.primaryAdminUseCase.request.addemployee
{
    public class AddHourlyEmployeeRequest : AddEmployeeRequest
    {

        public int? hourlyWage;

        public AddHourlyEmployeeRequest()
        {
        }
        public AddHourlyEmployeeRequest(int? employeeId, String name, String address, int? hourlyWage) : base(employeeId, name, address)
        {
            this.hourlyWage = hourlyWage;
        }
    }


}
