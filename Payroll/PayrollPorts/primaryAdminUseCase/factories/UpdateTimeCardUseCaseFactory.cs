using PayrollPorts.primaryAdminUseCase.request.hourly;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface UpdateTimeCardUseCaseFactory
    {
        CommandUseCase<UpdateTimeCardRequest> updateTimeCardUseCase();
    }

}