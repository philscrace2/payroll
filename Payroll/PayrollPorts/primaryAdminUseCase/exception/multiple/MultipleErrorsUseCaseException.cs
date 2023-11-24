namespace PayrollPorts.primaryAdminUseCase.exception.multiple
{
    public class MultipleErrorsUseCaseException<E> : UseCaseException
    {
        public List<E> Errors { get; }

        public MultipleErrorsUseCaseException(List<E> errors)
        {
            Errors = errors;
        }
    }
}

