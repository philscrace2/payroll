using PayrollInteractors.PayrollInteractors;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;
using PayrollPorts.secondary.database;

namespace PayrollInteractors
{
    public abstract class EmployeeGatewayFunctionUseCase<T, R> : TransactionalFunctionUseCase<T, R> where T : Request where R : Response

    {
        protected EmployeeGateway employeeGateway;

        public EmployeeGatewayFunctionUseCase(TransactionalRunner transactionalRunner, EmployeeGateway employeeGateway) : base(transactionalRunner)
        {
            this.employeeGateway = employeeGateway;
        }
    }


}