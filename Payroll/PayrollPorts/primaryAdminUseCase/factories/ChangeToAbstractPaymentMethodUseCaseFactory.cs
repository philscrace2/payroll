using PayrollPorts.primaryAdminUseCase.request.changemployee;
using PayrollPorts.primaryAdminUseCase.request.changemployee.paymentmethod;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface ChangeToAbstractPaymentMethodUseCaseFactory
    {
        CommandUseCase<ChangeToDirectPaymentMethodRequest> changeToDirectPaymentMethodUseCase();
        CommandUseCase<ChangeEmployeeRequest> changeToPaymasterPaymentMethodUseCase();
    }

}