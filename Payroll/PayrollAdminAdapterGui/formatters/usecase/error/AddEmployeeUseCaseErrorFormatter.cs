using PayrollAdminAdapterGui.formatters.common;
using PayrollPorts.primaryAdminUseCase.response.employee.add;

namespace PayrollAdminAdapterGui.formatters.usecase.error
{
    public class AddEmployeeUseCaseErrorFormatter : MultipleFormatter<IAddEmployeeError>, IAddEmployeeErrorVisitor
    {
        protected override string format(IAddEmployeeError error)
        {
            return error.Accept<string>(this);
        }

        public R Visit<R>(IdAlreadyExistsValidationError idAlreadyExistsValidationError)
        {
            return String.Format("%s already owns this id!", idAlreadyExistsValidationError.nameOfExistingUser);
        }

        public R Visit<R>(NameAlreadyExistsValidationError nameAlreadyExistsValidationError)
        {
            return String.Format("Name already exists with id: %s", nameAlreadyExistsValidationError.idOfExistingUser);
        }


    }

}