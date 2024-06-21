namespace PayrollPorts.primaryAdminUseCase.request.addemployee
{
    public class AddCommissionedEmployeeRequest : AddEmployeeRequest
    {
        public int? biWeeklyBaseSalary;
        public double commissionRate;

        public AddCommissionedEmployeeRequest()
        {
        }
        public AddCommissionedEmployeeRequest(int? employeeId, String name, String address,
                int? biWeeklyBaseSalary, double commissionRate) : base(employeeId, name, address)
        {

            this.biWeeklyBaseSalary = biWeeklyBaseSalary;
            this.commissionRate = commissionRate;
        }
    }

}
