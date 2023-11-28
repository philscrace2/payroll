using GuiWinformsModule;
using PayrollDBAdapterInMemory;
using PayrollDBAdapterJPA;
using PayrollMain.adapters.secondary.banktransfer;
using PayrollMain.main.testdataloader;
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


        public abstract class Builder
        {
            private Database database;
            private BankTransferPort bankTransferPort;
            private bool loadTestData;

            public Builder withDatabase(Database database)
            {
                this.database = database;
                return this;
            }

            public Builder withBankTransferPort(BankTransferPort bankTransferPort)
            {
                this.bankTransferPort = bankTransferPort;
                return this;
            }

            public Builder withLoadedTestData()
            {
                loadTestData = true;
                return this;
            }

            public UseCaseFactories buildUseCaseFactories()
            {
                checkBuildability();
                UseCaseFactories useCaseFactories = new PayrollNinjectModule(database, bankTransferPort).getUseCaseFactories();
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
                    LoadTestData(useCaseFactories);
            }

            private void LoadTestData(UseCaseFactories useCaseFactories)
            {
                new TestDataLoader().clearDatabaseAndInsertTestData(database, useCaseFactories);
            }

            private static void checkForNull(Object o, String message)
            {
                if (o == null)
                {
                    throw new NullReferenceException(message);
                }
            }

            public GuiWinformsImpl buildGuiAdminSwing()
            {
                return new GuiWinformsImpl(buildUseCaseFactories());
            }

        }

        public class ConcreteBuilder : Payroll.Builder
        {
            public ConcreteBuilder withDatabaseInMemory()
            {
                withDatabase(new InMemoryDatabase());
                return this;
            }

            public ConcreteBuilder withDatabaseJPA(JPAPersistenceUnit jpaPersistenceUnit)
            {
                withDatabase(PayrollDBAdapterJPA.JPADatabaseModule.createAndStart(jpaPersistenceUnit).getDatabase());
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









