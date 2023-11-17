using PayrollEntities;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;
using PayrollPorts.secondary.database;
using static PayrollPorts.primaryAdminUseCase.response.GetEmployeeResponse;

namespace PayrollInteractors.usecases.employee.find
{
    public class GetEmployeeUseCase : EmployeeGatewayFunctionUseCase<GetEmployeeRequest, GetEmployeeResponse>
    {


        private GetEmployeeResponseCreator getEmployeeResponseCreator = new GetEmployeeResponseCreator();

        public GetEmployeeUseCase(TransactionalRunner transactionalRunner, EmployeeGateway employeeGateway) : base(transactionalRunner, employeeGateway)
        {

        }


        protected override GetEmployeeResponse ExecuteInTransaction(GetEmployeeRequest request)
        {
            return getEmployeeResponseCreator.toResponse(employeeGateway.findById(request.employeeId));
        }


        private class GetEmployeeResponseCreator
        {
            public GetEmployeeResponse toResponse(Employee employee)
            {
                return new GetEmployeeResponse(to(employee));
            }

            private EmployeeForGetEmployeeResponse to(Employee employee)
            {
                EmployeeForGetEmployeeResponse response = new EmployeeForGetEmployeeResponse();
                response.id = employee.getId();
                response.name = employee.getName();
                response.address = employee.getAddress();
                return response;
            }

        }
    }

}