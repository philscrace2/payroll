using GuiWinformsModule;
using PayrollMain.adapters.secondary.banktransfer;
using PayrollPorts.primaryAdminUseCase;
using PayrollPorts.secondary.banktransfer;
using PayrollPorts.secondary.database;

namespace PayrollMain
{
    public class PayrollBuilder
    {
        public static Payroll.ConcreteBuilder builder()
        {
            return new Payroll.ConcreteBuilder();
        }

    }

    public class Payroll
    {

        public static ConcreteBuilder builder()
        {
            return new ConcreteBuilder();
        }


        public abstract class Builder<T>
        {
            private Database database;
            private BankTransferPort bankTransferPort;
            private bool loadTestData;

            public T withDatabase(Database database)
            {
                this.database = database;
                return (T)this;
            }

            public T withBankTransferPort(BankTransferPort bankTransferPort)
            {
                this.bankTransferPort = bankTransferPort;
                return (T)this;
            }

            public T withLoadedTestData()
            {
                loadTestData = true;
                return (T)this;
            }

            public UseCaseFactories buildUseCaseFactories()
            {
                checkBuildability();
                UseCaseFactories useCaseFactories = new PayrollModule(database, bankTransferPort).getUseCaseFactories();
                loadTestDataIfRequested(useCaseFactories);
                return useCaseFactories;
            }

            private void checkBuildability()
            {
                checkForNull(database, "database should be selected");
                checkForNull(bankTransferPort, "bankTransferPort should be selected");
            }

            private void loadTestDataIfRequested(UseCaseFactories useCaseFactories)
            {
                if (loadTestData)
                    loadTestData(useCaseFactories);
            }

            private void loadTestData(UseCaseFactories useCaseFactories)
            {
                new TestDataLoader().clearDatabaseAndInsertTestData(database, useCaseFactories);
            }

            private static void checkForNull(Object o, String message)
            {
                if (o == null)
                {
                    throw new NullPointerException(message);
                }
            }

            public GuiWinformsImpl buildGuiAdminSwing()
            {
                return new GuiWinformsImpl(buildUseCaseFactories());
            }

        }


        public class ConcreteBuilder : Payroll.Builder<ConcreteBuilder>
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

}









