using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.secondary.database;

namespace PayrollInteractors
{
    public abstract class EmployeeGatewayCommandUseCase<R> : TransactionalCommandUseCase<R> where R : Request
    {
        protected EmployeeGateway employeeGateway;

        public EmployeeGatewayCommandUseCase(TransactionalRunner transactionalRunner, EmployeeGateway employeeGateway) : base(transactionalRunner)
        {

            this.employeeGateway = employeeGateway;
        }

    }
}



