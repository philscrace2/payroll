namespace PayrollMain
{
    public class PayrollBuilder
    {
        public static ConcreteBuilder builder()
        {
            return new ConcreteBuilder();
        }

    }

    public class ConcreteBuilder : Builder<ConcreteBuilder>
    {
        public ConcreteBuilder withDatabaseInMemory()
        {
            withDatabase(new InMemoryDatabase());
            return this;
        }
        public ConcreteBuilder withDatabaseJPA(JPAPersistenceUnit jpaPersistenceUnit)
        {
            withDatabase(JPADatabaseModule.createAndStart(jpaPersistenceUnit).getDatabase());
            return this;
        }
        public ConcreteBuilder withBankTransferPortFake()
        {
            withBankTransferPort(new FakeBankTransferPort());
            return this;
        }


    }


}








