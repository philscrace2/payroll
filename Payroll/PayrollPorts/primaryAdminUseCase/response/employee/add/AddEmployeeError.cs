using PayrollPorts.primaryAdminUseCase.exception.multiple;

namespace PayrollPorts.primaryAdminUseCase.response.employee.add
{
    public interface IAddEmployeeError : Error, IVisitable<IAddEmployeeError.IAddEmployeeErrorVisitor, IAddEmployeeError>
    {
        public interface IAddEmployeeErrorVisitor : IVisitor<IAddEmployeeErrorVisitor, IAddEmployeeError>
        {
            R Visit<R>(IdAlreadyExistsValidationError idAlreadyExistsValidationError);
            R Visit<R>(NameAlreadyExistsValidationError nameAlreadyExistsValidationError);
        }

    }



}