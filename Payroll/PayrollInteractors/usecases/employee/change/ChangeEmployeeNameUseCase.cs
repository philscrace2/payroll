using PayrollEntities;
using PayrollPorts.primaryAdminUseCase.request.changemployee;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.employee.change
{
    public class ChangeEmployeeNameUseCase : ChangeEmployeeUseCase<ChangeEmployeeNameRequest>
    {
        public ChangeEmployeeNameUseCase(TransactionalRunner transactionalRunner, EmployeeGateway employeeGateway) : base(transactionalRunner, employeeGateway)
        {

        }
        protected override void change(Employee employee, ChangeEmployeeNameRequest request)
        {
            employee.setName(request.newName);
        }
    }

}