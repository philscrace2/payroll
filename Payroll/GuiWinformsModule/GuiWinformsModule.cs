using Ninject.Modules;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe;
using PayrollGuiWinformsImpl.viewimpl;
using PayrollPorts.primaryAdminUseCase;
using PayrollPorts.primaryAdminUseCase.factories;

namespace PayrollGuiWinformsImpl
{
    public class GuiWinformsModule : NinjectModule
    {

        private UseCaseFactories useCaseFactories;

        public GuiWinformsModule(UseCaseFactories useCaseFactories)
        {
            this.useCaseFactories = useCaseFactories;
        }

        private void bindUseCaseFactories()
        {
            Bind<DeleteEmployeeUseCaseFactory>().ToConstant(useCaseFactories);
            Bind<DeleteEmployeeUseCaseFactory>().ToConstant(useCaseFactories);
            //bind(GetEmployeeUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(EmployeeListUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(PaymentFulfillUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(PayListUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(AddEmployeeUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(AddTimeCardUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(UpdateTimeCardUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(ChangeToAbstractPaymentMethodUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(ChangeToAbstractPaymentMethodUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(GetUnionMemberAffiliationUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(AddUnionMemberAffiliationUseCaseFactory.class).toProvider(useCaseFactories);
            //bind(RemoveUnionMemberAffiliationUseCaseFactory.class).toProvider(useCaseFactories);
        }

        private void bindUIs()
        {

            //Kernel.Bind(new TypeLiteral<AddEmployeeUI<?>>() { })to(AddEmployeeUIImpl.class);
            //bind(new TypeLiteral<ErrorDialogUI<?>>() { }).to(ErrorDialogUIImpl.class);
            //bind(ConfirmDialogUI.class).to(ConfirmDialogUIImpl.class);
            Kernel.Bind<MainFrameUI>().To<MainFrameUIImpl>();
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
            bindUseCaseFactories();
            bindUIs();
            bindEagerSingletons();
            installAssistedFactories();
        }
    }
}
