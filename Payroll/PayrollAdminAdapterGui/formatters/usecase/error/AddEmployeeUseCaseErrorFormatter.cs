using PayrollAdminAdapterGui.formatters.common;
using PayrollPorts.primaryAdminUseCase.response.employee.add;

namespace PayrollAdminAdapterGui.formatters.usecase.error
{
    public class AddEmployeeUseCaseErrorFormatter : MultipleFormatter, IAddEmployeeError.IAddEmployeeErrorVisitor
    {


        public String Visit<R>(IdAlreadyExistsValidationError idAlreadyExistsValidationError)
        {
            return String.Format("%s already owns this id!", idAlreadyExistsValidationError.nameOfExistingUser);
        }

        R IAddEmployeeError.IAddEmployeeErrorVisitor.Visit<R>(NameAlreadyExistsValidationError nameAlreadyExistsValidationError)
        {
            throw new NotImplementedException();
        }

        R IAddEmployeeError.IAddEmployeeErrorVisitor.Visit<R>(IdAlreadyExistsValidationError idAlreadyExistsValidationError)
        {
            throw new NotImplementedException();
        }

        public String Visit<R>(NameAlreadyExistsValidationError nameAlreadyExistsValidationError)
        {
            return String.Format("Name already exists with id: %s", nameAlreadyExistsValidationError.idOfExistingUser);
        }


        protected override string format(string element)
        {
            throw new NotImplementedException();
        }
    }

}