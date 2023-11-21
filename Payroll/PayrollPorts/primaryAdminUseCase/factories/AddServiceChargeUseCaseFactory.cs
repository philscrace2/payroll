using PayrollPorts.primaryAdminUseCase.request;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface AddServiceChargeUseCaseFactory
    {
        CommandUseCase<AddServiceChargeRequest> addServiceChargeUseCase();
    }

}