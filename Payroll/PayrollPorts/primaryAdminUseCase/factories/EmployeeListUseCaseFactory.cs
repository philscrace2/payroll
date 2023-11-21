using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface EmployeeListUseCaseFactory
    {
        IFunctionUseCase<EmployeeListRequest, EmployeeListResponse> employeeListUseCase();
    }


}