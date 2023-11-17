namespace PayrollPorts.primaryAdminUseCase.exception.multiple
{
    public class MultipleErrorsUseCaseException<E> : UseCaseException where E : Error
    {
        public List<E> Errors { get; }

        public MultipleErrorsUseCaseException(List<E> errors)
        {
            Errors = errors;
        }
    }
}

