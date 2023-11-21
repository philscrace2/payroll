using PayrollPorts.primaryAdminUseCase.request.changemployee;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface ChangeEmployeeUseCaseFactory
    {
        CommandUseCase<ChangeEmployeeNameRequest> changeEmployeeNameUseCase();
    }

}