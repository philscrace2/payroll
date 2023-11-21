using PayrollAdminAdapterGui.events;
using PayrollAdminAdapterGui.formatters.controller;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addtimecard;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.common.confirm;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager;
using PayrollPorts.primaryAdminUseCase.factories;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;
using PayrollPorts.primaryAdminUseCase.response.employee;
using PayrollPorts.primaryAdminUseCase.response.employee.paymenttype;
using static PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.EmployeeManagerViewModel;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel
{
    public class EmployeeManagerController : AbstractController<EmployeeManagerView, EmployeeManagerViewListener>, EmployeeManagerViewListener
    {
        private DeleteEmployeeUseCaseFactory deleteEmployeeUseCaseFactory;
        private EventBus eventBus;

        private AddEmployeeUI addEmployeeUIProvider;
        private ConfirmDialogUI confirmDialogUIProvider;
        private AddTimeCardUIFactory addTimeCardUIFactory;
        private ObservableSelectedEmployee observableSelectedEployee;
        private ConfirmMessageFormatter confirmMessageFormatter;

        //@Inject
        public EmployeeManagerController(
        DeleteEmployeeUseCaseFactory deleteEmployeeUseCaseFactory,
        GetEmployeeUseCaseFactory getEmployeeUseCaseFactory,
        EventBus eventBus,
        AddEmployeeUI addEmployeeUIProvider,
        ConfirmDialogUI confirmDialogUIProvider,
        AddTimeCardUIFactory addTimeCardUIFactory,
        ConfirmMessageFormatter confirmMessageFormatter
        )
        {
            this.deleteEmployeeUseCaseFactory = deleteEmployeeUseCaseFactory;
            this.eventBus = eventBus;
            this.addEmployeeUIProvider = addEmployeeUIProvider;
            this.confirmDialogUIProvider = confirmDialogUIProvider;
            this.addTimeCardUIFactory = addTimeCardUIFactory;
            this.confirmMessageFormatter = confirmMessageFormatter;
        }

        public void setObservableSelectedEmployee(ObservableSelectedEmployee observableSelectedEployee)
        {
            this.observableSelectedEployee = observableSelectedEployee;
            observableSelectedEployee.addChangeListener(() =>
            {
                onSelectedEmployeeIdChanged();
            });
        }

        protected override EmployeeManagerViewListener GetViewListener()
        {
            return this;
        }

        private void onSelectedEmployeeIdChanged()
        {
            updateView();
        }

        private void updateView()
        {
            GetView().setModel(new EmployeeManagerViewPresenter().present(observableSelectedEployee.get()));
        }


        public void onDeleteEmployeeAction()
        {
            var employee = this.observableSelectedEployee.get; // Assuming observableSelectedEmployee is a property of type Observable<EmployeeForEmployeeListResponse>
            var confirmDialog = confirmDialogUIProvider; // Assuming confirmDialogUIProvider is a provider or factory for ConfirmDialogUI
            confirmDialog.show(
                confirmMessageFormatter.deleteEmployee(employee),
                new ConfirmDialogListener(
                    () =>
                    {
                        deleteEmployeeUseCaseFactory.DeleteEmployeeUseCase().Execute(new DeleteEmployeeRequest(employee.Id));
                        eventBus.Post(new DeletedEmployeeEvent(employee.Id, employee.Name));
                    }
                ));
        }



        public void onAddEmployeeAction()
        {
            addEmployeeUIProvider.get().show();
        }


        public void onAddSalesReceiptAction()
        {
            eventBus.Post(new CalledNotImplementedFunctionEvent("AddSalesReceipt"));
            // TODO Auto-generated method stub
        }


        public void onAddServiceChargeAction()
        {
            eventBus.Post(new CalledNotImplementedFunctionEvent("AddServiceCharge"));
            // TODO Auto-generated method stub
        }


        public void onAddTimeCardAction()
        {
            addTimeCardUIFactory.Create(observableSelectedEployee.get().id).show();
        }
    }



    public class EmployeeManagerViewPresenter
    {
        public EmployeeManagerViewModel present(EmployeeForEmployeeListResponse selectedEmployee)
        {
            return new EmployeeManagerViewModel(presentButtonsEnabledStates(selectedEmployee));
        }

        private ButtonEnabledStates presentButtonsEnabledStates(EmployeeForEmployeeListResponse selectedEmployee)
        {
            ButtonEnabledStates buttonsEnabledStates = new ButtonEnabledStates();
            buttonsEnabledStates.deleteEmployee = selectedEmployee.isPresent();
            selectedEmployee.ifPresent((e) =>
            {
                presentButtonsEnabledStatesForEmployee(buttonsEnabledStates, e);
            });
            return buttonsEnabledStates;
        }

        private void presentButtonsEnabledStatesForEmployee(ButtonEnabledStates buttonsEnabledStates, EmployeeForEmployeeListResponse employee)
        {
            presentButtonsEnabledForPaymentType(buttonsEnabledStates, employee.paymentTypeResponse);
            presentButtonsEnabledForAffiliationType(buttonsEnabledStates, employee.affiliationTypeResponse);
        }

        private void presentButtonsEnabledForPaymentType(ButtonEnabledStates buttonsEnabledStates, PaymentTypeResponse paymentType)
        {
            paymentType.accept(new PaymentTypeResponseVisitor<PaymentTypeResponse>())
            {

            }


        public override void visit(CommissionedPaymentTypeResponse commissionedPaymentTypeResponse)
        {
            buttonsEnabledStates.addSalesReceipt = true;
            return null;
        }
    });
    private void presentButtonsEnabledForAffiliationType(ButtonEnabledStates buttonsEnabledStates, AffiliationTypeResponse affiliationType)
    {
        switch (affiliationType)
        {
            case NO:
                break;
            case UNION_MEMBER:
                buttonsEnabledStates.addServiceCharge = true;
                break;
            default:
                throw new Exception("not implemented");
        }
    }
}



