using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;

namespace PayrollPorts.primaryAdminUseCase
{
    public interface IFunctionUseCase<T, R> : UseCase where T : Request where R : Response
    {
        R Execute(T request);
    }

}
