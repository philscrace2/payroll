using PayrollPorts.secondary.database;

namespace PayrollDBAdapterInMemory
{
    public class InMemoryDatabase : Database
    {
        private InMemoryTransactionalRunner _transactionalRunner = new InMemoryTransactionalRunner();
        private EmployeeGateway _employeeGateway = new InMemoryEntityGateway();

        public InMemoryDatabase()
        {
        }


        public TransactionalRunner transactionalRunner()
        {
            return _transactionalRunner;
        }


        public EmployeeGateway employeeGateway()
        {
            return _employeeGateway;
        }


        public EntityFactory entityFactory()
        {
            return new InMemoryEntityFactory();
        }

    }

}