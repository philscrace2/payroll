namespace PayrollPorts.secondary.database
{
    public interface TransactionalRunner
    {
        void ExecuteInTransaction(Executable.Runnable runnable);
    }

    public class Executable
    {
        public delegate void Runnable();
    }

}
