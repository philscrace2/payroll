using PayrollPorts.primaryAdminUseCase.request.hourly;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface AddTimeCardUseCaseFactory
    {
        CommandUseCase<AddTimeCardRequest> addTimeCardUseCase();
    }

}