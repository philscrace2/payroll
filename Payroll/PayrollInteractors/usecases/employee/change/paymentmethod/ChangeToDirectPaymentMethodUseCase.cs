using PayrollEntities.paymentmethod;
using PayrollPorts.primaryAdminUseCase.request.changemployee.paymentmethod;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.employee.change.paymentmethod
{
    public class ChangeToDirectPaymentMethodUseCase : ChangeToAbstractPaymentMethodUseCase<ChangeToDirectPaymentMethodRequest>
    {


        private PaymentMethodFactory paymentMethodFactory;

        public ChangeToDirectPaymentMethodUseCase(
                TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway,
                PaymentMethodFactory paymentMethodFactory
                ) : base(transactionalRunner, employeeGateway)
        {
            this.paymentMethodFactory = paymentMethodFactory;
        }


        protected override PaymentMethod getPaymentMethod(ChangeToDirectPaymentMethodRequest request)
        {
            return paymentMethodFactory.directPaymentMethod(request.accountNumber);
        }


    }



}