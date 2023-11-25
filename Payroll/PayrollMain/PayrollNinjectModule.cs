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
            return Guice.createInjector(this).getInstance(UseCaseFactories);
        }

        public UseCaseFactories getUseCaseFactories()
        {
            return UseCaseFactories;
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}
