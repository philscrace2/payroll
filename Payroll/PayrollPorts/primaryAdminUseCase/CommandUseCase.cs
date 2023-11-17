namespace PayrollPorts.primaryAdminUseCase
{
    public interface CommandUseCase<T> : UseCase
    {
        public void Execute(T request);
    }
}
