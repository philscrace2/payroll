using PayrollPorts.primaryAdminUseCase.response.employee;

namespace PayrollPorts.primaryAdminUseCase.response
{
    public class GetEmployeeResponse : Response
    {

        public EmployeeForGetEmployeeResponse employeeForGetEmployeeResponse;

        public GetEmployeeResponse(EmployeeForGetEmployeeResponse employeeForGetEmployeeResponse)
        {
            this.employeeForGetEmployeeResponse = employeeForGetEmployeeResponse;
        }

        public class EmployeeForGetEmployeeResponse : EmployeeBaseForResponse
        {
        }
    }

}