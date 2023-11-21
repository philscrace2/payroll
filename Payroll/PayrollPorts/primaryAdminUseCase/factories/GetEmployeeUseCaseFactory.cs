using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface GetEmployeeUseCaseFactory
    {
        IFunctionUseCase<GetEmployeeRequest, GetEmployeeResponse> getEmployeeUseCase();
    }


}