using Ninject.Activation;
using Ninject.Modules;
using PayrollPorts.primaryAdminUseCase;
namespace GuiWinformsModule
{
    public class GuiSwingModule : NinjectModule
    {

        private Provider<UseCaseFactories> useCaseFactories;

        public GuiSwingModule(Provider<UseCaseFactories> useCaseFactories)
        {
            this.useCaseFactories = useCaseFactories;
        }


        protected void configure()
        {
            bindUseCaseFactories();
            bindUIs();
            bindEagerSingletons();
            installAssistedFactories();
        }

        private void bindUseCaseFactories()
        {
            //    bind(DeleteEmployeeUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(GetEmployeeUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(EmployeeListUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(PaymentFulfillUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(PayListUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(AddEmployeeUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(AddTimeCardUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(UpdateTimeCardUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(ChangeToAbstractPaymentMethodUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(GetUnionMemberAffiliationUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(AddUnionMemberAffiliationUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(RemoveUnionMemberAffiliationUseCaseFactory.class).toProvider(useCaseFactories);
        }

        private void bindUIs()
        {
            //        bind(new TypeLiteral<AddEmployeeUI<?>>() { }).to(AddEmployeeUIImpl.class);
            //bind(new TypeLiteral<ErrorDialogUI<?>>() { }).to(ErrorDialogUIImpl.class);
            //bind(ConfirmDialogUI.class).to(ConfirmDialogUIImpl.class);
            //bind(MainFrameUI.class).to(MainFrameUIImpl.class);
        }

        private void bindEagerSingletons()
        {
            //    bind(EventBus.class).to(EventQueueAsyncEventBus.class).asEagerSingleton();
            //bind(UncaugthExceptionHandler.class).asEagerSingleton();
        }

        private void installAssistedFactories()
        {
            //            install(new FactoryModuleBuilder().implement(new TypeLiteral<AddTimeCardUI<? extends AddTimeCardView>>() { }, AddTimeCardUIImpl.class).build(AddTimeCardUIFactory.class));
            //install(new FactoryModuleBuilder().implement(new TypeLiteral<AddUnionMemberUI<? extends AddUnionMemberView>>() { }, AddUnionMemberUIImpl.class).build(AddUnionMemberUIFactory.class));
            //install(new FactoryModuleBuilder().build(AddTimeCardControllerFactory.class));
            //install(new FactoryModuleBuilder().build(AddUnionMemberControllerFactory.class));
            //install(new FactoryModuleBuilder().build(EmployeeListPresenterFactory.class));
            //install(new FactoryModuleBuilder().build(SmartDateFormatterFactory.class));
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}
