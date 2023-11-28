using PayrollPorts.secondary.database;

namespace PayrollDBAdapterInMemory
{
    public class InMemoryTransactionalRunner : TransactionalRunner
    {
        /** transactional behavior not implemented for inmemory**/

        public void ExecuteInTransaction(Executable.Runnable runnable)
        {
            runnable.Invoke();
        }

    }
}