using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface PayListUseCaseFactory
    {
        IFunctionUseCase<PayListRequest, PayListResponse> payListUseCase();
    }

}