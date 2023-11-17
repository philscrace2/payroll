using PayrollPorts.primaryAdminUseCase.exception;

namespace PayrollInteractors
{
    public class AbstractUseCase
    {
        private bool executed;

        protected void CheckFirstExecution()
        {
            if (executed)
                throw new UseCaseAlreadyExecutedException();
            executed = true;
        }


    }

    public class UseCaseAlreadyExecutedException : UseCaseException
    {
    }


}
