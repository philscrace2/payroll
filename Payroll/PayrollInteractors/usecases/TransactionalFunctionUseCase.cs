using PayrollPorts.primaryAdminUseCase;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;
using PayrollPorts.secondary.database;

namespace PayrollInteractors
{
    namespace PayrollInteractors
    {
        public abstract class TransactionalFunctionUseCase<T, R> : AbstractUseCase, IFunctionUseCase<T, R>
            where T : Request
            where R : Response
        {
            private readonly TransactionalRunner _transactionalRunner;

            public TransactionalFunctionUseCase(TransactionalRunner transactionalRunner)
            {
                _transactionalRunner = transactionalRunner;
            }

            public R Execute(T request)
            {
                CheckFirstExecution();
                var response = new Holder<R>();
                _transactionalRunner.ExecuteInTransaction(() =>
                {
                    response.Value = ExecuteInTransaction(request);
                });
                return response.Value;
            }

            protected abstract R ExecuteInTransaction(T request);

            private class Holder<T>
            {
                public T Value;
            }
        }
    }

}