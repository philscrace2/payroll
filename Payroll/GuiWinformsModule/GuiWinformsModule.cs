using Ninject.Modules;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.common.confirm;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist;
using PayrollGuiWinformsImpl.viewimpl;
using PayrollGuiWinformsImpl.viewimpl.dialog.addemployee;
using PayrollGuiWinformsImpl.viewimpl.dialog.common;
using PayrollGuiWinformsImpl.viewimpl.mainframe;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.pay;
using PayrollPorts.primaryAdminUseCase;
using PayrollPorts.primaryAdminUseCase.factories;
using static PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table.EmployeeListPresenter;

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
            //ConfirmDialogUIImpl: ConfirmDialogUI

            Bind(typeof(ConfirmDialogUI)).To(typeof(ConfirmDialogUIImpl));
            Bind(typeof(AddEmployeeUI<>)).To(typeof(AddEmployeeUIImpl<>));
            Bind(typeof(EmployeeListPresenterFactory)).To(typeof(EmployeeListPresenterFactoryImpl));
            Bind<MainFrameUI>().To<MainFrameUIImpl>();
            Bind(typeof(MainPanelUI<MainPanelView>)).To(typeof(MainPanelUIImpl));

            //Bind(new TypeLiteral<ErrorDialogUI<?>>() { }).to(ErrorDialogUIImpl.class);
            Bind(typeof(PayListUI<>)).To(typeof(PayListUIImpl<>));
            Bind<PayListView>().To<PayListPanel>();

        }

        private void bindEagerSingletons()
        {
            //Bind<EventBus>().To<EventQueueAsyncEventBus>();
            //bind(UncaugthExceptionHandler.class).asEagerSingleton();
        }

        private void installAssistedFactories()
        {
            //install(new FactoryModuleBuilder().implement(new TypeLiteral<AddTimeCardUI<? extends AddTimeCardView>>() { }, AddTimeCardUIImpl.class).build(AddTimeCardUIFactory.class));
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
