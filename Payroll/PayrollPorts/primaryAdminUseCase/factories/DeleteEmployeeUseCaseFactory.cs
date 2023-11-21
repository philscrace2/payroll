using PayrollPorts.primaryAdminUseCase.request;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface DeleteEmployeeUseCaseFactory
    {
        CommandUseCase<DeleteEmployeeRequest> deleteEmployeeUseCase();
    }


}