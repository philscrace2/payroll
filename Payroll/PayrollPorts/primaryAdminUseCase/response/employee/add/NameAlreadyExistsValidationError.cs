namespace PayrollPorts.primaryAdminUseCase.response.employee.add
{
    public class NameAlreadyExistsValidationError : IAddEmployeeError
    {

        public int idOfExistingUser;
        public NameAlreadyExistsValidationError(int idOfExistingUser)
        {
            this.idOfExistingUser = idOfExistingUser;
        }

        public R Accept<R>(IAddEmployeeError.IAddEmployeeErrorVisitor visitor)
        {
            return visitor.Visit<R>(this);
        }
    }

}