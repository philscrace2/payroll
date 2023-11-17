using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.employee
{
    public class DeleteEmployeeUseCase : EmployeeGatewayCommandUseCase<DeleteEmployeeRequest>
    {
        public DeleteEmployeeUseCase(TransactionalRunner transactionalRunner, EmployeeGateway employeeGateway) : base(transactionalRunner, employeeGateway)
        {

        }


        protected override void ExecuteInTransaction(DeleteEmployeeRequest request)
        {
            employeeGateway.deleteById(request.employeeId);
        }

    }

}