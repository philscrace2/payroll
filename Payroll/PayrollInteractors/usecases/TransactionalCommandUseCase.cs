using PayrollPorts.primaryAdminUseCase;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.secondary.database;


namespace PayrollInteractors
{
    public abstract class TransactionalCommandUseCase<T> : AbstractUseCase, CommandUseCase<T> where T : Request
    {
        private readonly TransactionalRunner _transactionalRunner;

        public TransactionalCommandUseCase(TransactionalRunner transactionalRunner)
        {
            _transactionalRunner = transactionalRunner;
        }

        public void Execute(T request)
        {
            CheckFirstExecution();
            _transactionalRunner.ExecuteInTransaction(() => ExecuteInTransaction(request));
        }

        protected abstract void ExecuteInTransaction(T request);
    }

}