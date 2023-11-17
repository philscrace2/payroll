using PayrollEntities.paymentmethod;
using PayrollPorts.primaryAdminUseCase.request.changemployee;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.employee.change.paymentmethod
{
    public class ChangeToPaymasterPaymentMethodUseCase : ChangeToAbstractPaymentMethodUseCase<ChangeEmployeeRequest>
    {
        private PaymentMethodFactory paymentMethodFactory;

        public ChangeToPaymasterPaymentMethodUseCase(
                TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway,
                PaymentMethodFactory paymentMethodFactory
                ) : base(transactionalRunner, employeeGateway)
        {

            this.paymentMethodFactory = paymentMethodFactory;
        }

        protected override PaymentMethod getPaymentMethod(ChangeEmployeeRequest request)
        {
            return paymentMethodFactory.paymasterPaymentMethod();
        }

    }

}