using PayrollPorts.primaryAdminUseCase.exception.multiple;

namespace PayrollInteractors.exception
{
    public abstract class MultipleErrorsUseCaseExceptionThrower<E> where E : Error
    {
        private List<E> errors = new List<E>();

        public MultipleErrorsUseCaseExceptionThrower()
        {
            addErrors();
            throwIfThereAreErrors();
        }

        protected abstract void addErrors();

        protected void addError(E error)
        {
            errors.Add(error);
        }

        public void throwIfThereAreErrors()
        {
            if (errors.Count != 0)
                throw new MultipleErrorsUseCaseException<E>(errors);
        }

    }



}