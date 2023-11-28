using Ninject;
using Ninject.Modules;
using PayrollPorts.primaryAdminUseCase;
using PayrollPorts.secondary.banktransfer;
using PayrollPorts.secondary.database;

namespace PayrollMain
{
    public class PayrollNinjectModule : NinjectModule
    {
        private readonly Database database;
        private readonly BankTransferPort bankTransferPort;
        private readonly UseCaseFactories useCaseFactories;

        public PayrollNinjectModule(Database database, BankTransferPort bankTransferPort)
        {
            this.database = database;
            this.bankTransferPort = bankTransferPort;
            this.useCaseFactories = createUseCaseFactories();
        }

        private UseCaseFactories createUseCaseFactories()
        {
            IKernel kernel = new StandardKernel(this);
            return kernel.Get<UseCaseFactories>();
        }

        public UseCaseFactories getUseCaseFactories()
        {
            return useCaseFactories;
        }

        public override void Load()
        {
            // Bind your services here. For example:
            Bind<Database>().ToConstant(database);
            Bind<BankTransferPort>().ToConstant(bankTransferPort);

            // Assuming UseCaseFactories needs to be injected with Database and BankTransferPort
            Bind<UseCaseFactories>().ToSelf().WithConstructorArgument("database", database);
        }
    }
}
