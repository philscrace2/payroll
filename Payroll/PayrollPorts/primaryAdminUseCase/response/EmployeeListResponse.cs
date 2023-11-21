using PayrollPorts.primaryAdminUseCase.response.employee;
using PayrollPorts.primaryAdminUseCase.response.employee.paymenttype;

namespace PayrollPorts.primaryAdminUseCase.response
{
    public class EmployeeListResponse : Response
    {

        public List<EmployeeForEmployeeListResponse> employees;

        public EmployeeListResponse(List<EmployeeForEmployeeListResponse> employees)
        {
            this.employees = employees;
        }

    }

    public class EmployeeForEmployeeListResponse : EmployeeBaseForResponse
    {
        public PaymentTypeResponse paymentTypeResponse;
        public AffiliationTypeResponse affiliationTypeResponse;
        public DateTime nextPayDay;
    }

}