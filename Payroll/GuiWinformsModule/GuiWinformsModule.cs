using Ninject.Modules;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
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
            Bind<GetEmployeeUseCaseFactory>().ToConstant(useCaseFactories);
            Bind<EmployeeListUseCaseFactory>().ToConstant(useCaseFactories);
            Bind<PaymentFulfillUseCaseFactory>().ToConstant(useCaseFactories);
            Bind<PayListUseCaseFactory>().ToConstant(useCaseFactories);
            Bind<AddEmployeeUseCaseFactory>().ToConstant(useCaseFactories);
            Bind<AddTimeCardUseCaseFactory>().ToConstant(useCaseFactories);
            Bind<UpdateTimeCardUseCaseFactory>().ToConstant(useCaseFactories);
            Bind<ChangeToAbstractPaymentMethodUseCaseFactory>().ToConstant(useCaseFactories);
            Bind<GetUnionMemberAffiliationUseCaseFactory>().ToConstant(useCaseFactories);
            Bind<AddUnionMemberAffiliationUseCaseFactory>().ToConstant(useCaseFactories);
            Bind<RemoveUnionMemberAffiliationUseCaseFactory>().ToConstant(useCaseFactories);
        }

        private void bindUIs()
        {

            Bind(AddEmployeeUI).To(AddEmployeeUIImpl);
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
