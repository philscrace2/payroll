using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface PaymentFulfillUseCaseFactory
    {
        IFunctionUseCase<PaymentFulfillRequest, PaymentFulfillResponse> paymentFulfillUseCase();
    }

}