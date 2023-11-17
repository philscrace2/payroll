using System.Collections.Generic;

namespace PayrollInteractors.exception
{
    public abstract class MultipleErrorsUseCaseExceptionThrower<E extends Error>
    {
        private List<E> errors = new ArrayList<>();

        public MultipleErrorsUseCaseExceptionThrower() throws MultipleErrorsUseCaseException
        {
            addErrors();
		throwIfThereAreErrors();
    }

    protected abstract void addErrors();

    protected void addError(E error)
    {
        errors.add(error);
    }

    public void throwIfThereAreErrors()
    {
        if (!errors.isEmpty())
            throw new MultipleErrorsUseCaseException(errors);
    }

}



}