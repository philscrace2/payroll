using PayrollEntities;
using PayrollPorts.primaryAdminUseCase.request.changemployee;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.employee.change
{
    public abstract class ChangeEmployeeUseCase<T> : EmployeeGatewayCommandUseCase<T> where T : ChangeEmployeeRequest
    {
        public ChangeEmployeeUseCase(TransactionalRunner transactionalRunner, EmployeeGateway employeeGateway) : base(transactionalRunner, employeeGateway)
        {

        }

        protected override void ExecuteInTransaction(T request)
        {
            change(employeeGateway.findById(request.employeeId), request);
        }

        protected abstract void change(Employee employee, T request);
    }

}