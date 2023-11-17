using PayrollEntities;
using PayrollEntities.paymentmethod;
using PayrollPorts.primaryAdminUseCase.request.changemployee;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.employee.change.paymentmethod
{
    public abstract class ChangeToAbstractPaymentMethodUseCase<T> : ChangeEmployeeUseCase<T> where T : ChangeEmployeeRequest
    {
        public ChangeToAbstractPaymentMethodUseCase(
                TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway
                ) : base(transactionalRunner, employeeGateway)
        {

        }


        protected override void change(Employee employee, T request)
        {
            employee.setPaymentMethod(getPaymentMethod(request));
        }

        protected abstract PaymentMethod getPaymentMethod(T request);
    }


}