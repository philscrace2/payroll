

namespace PayrollPorts.primaryAdminUseCase.response.employee.add
{
    public class IdAlreadyExistsValidationError : IAddEmployeeError
    {

        public String nameOfExistingUser;
        public IdAlreadyExistsValidationError(String nameOfExistingUser)
        {
            this.nameOfExistingUser = nameOfExistingUser;
        }
        public R Accept<R>(IAddEmployeeErrorVisitor visitor)
        {
            return visitor.Visit<R>(this);
        }

    }

}