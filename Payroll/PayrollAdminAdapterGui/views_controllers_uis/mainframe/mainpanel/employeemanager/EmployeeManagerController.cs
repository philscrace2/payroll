using PayrollAdminAdapterGui.events;
using PayrollAdminAdapterGui.formatters.controller.msg;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addtimecard;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.common.confirm;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager;
using PayrollPorts.primaryAdminUseCase.factories;
using PayrollPorts.primaryAdminUseCase.response;
using PayrollPorts.primaryAdminUseCase.response.employee;
using PayrollPorts.primaryAdminUseCase.response.employee.paymenttype;
using static PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.EmployeeManagerViewModel;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel
{
    public class EmployeeManagerController<V> : AbstractController<EmployeeManagerView, EmployeeManagerViewListener>, EmployeeManagerViewListener where V : AddEmployeeView
    {
        private DeleteEmployeeUseCaseFactory deleteEmployeeUseCaseFactory;
        private EventBus eventBus;

        private AddEmployeeUI<AddEmployeeView> addEmployeeUIProvider;
        private ConfirmDialogUI confirmDialogUIProvider;
        private AddTimeCardUIFactory addTimeCardUIFactory;
        private ObservableSelectedEmployee observableSelectedEployee;
        private ConfirmMessageFormatter confirmMessageFormatter;
        private ButtonEnabledStates buttonsEnabledStates;

        //@Inject
        public EmployeeManagerController(
        DeleteEmployeeUseCaseFactory deleteEmployeeUseCaseFactory,
        GetEmployeeUseCaseFactory getEmployeeUseCaseFactory,
        EventBus eventBus,
        AddEmployeeUI<AddEmployeeView> addEmployeeUIProvider,
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
            GetView().setModel(new EmployeeManagerViewPresenter(this.buttonsEnabledStates).present(observableSelectedEployee.get()));
        }


        public void onDeleteEmployeeAction()
        {
            //var employee = this.observableSelectedEployee.get; // Assuming observableSelectedEmployee is a property of type Observable<EmployeeForEmployeeListResponse>
            //var confirmDialog = confirmDialogUIProvider; // Assuming confirmDialogUIProvider is a provider or factory for ConfirmDialogUI
            //confirmDialog.show(
            //    confirmMessageFormatter.deleteEmployee(employee),
            //    new ConfirmDialogListener(
            //        () =>
            //        {
            //            deleteEmployeeUseCaseFactory.DeleteEmployeeUseCase().Execute(new DeleteEmployeeRequest(employee.Id));
            //            eventBus.Post(new DeletedEmployeeEvent(employee.Id, employee.Name));
            //        }
            //    ));
        }



        public void onAddEmployeeAction()
        {
            addEmployeeUIProvider.Show();
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
        private ButtonEnabledStates buttonsEnabledStates = null;

        public EmployeeManagerViewPresenter(ButtonEnabledStates buttonsEnabledStates)
        {
            this.buttonsEnabledStates = buttonsEnabledStates;
        }
        public EmployeeManagerViewModel present(EmployeeForEmployeeListResponse selectedEmployee)
        {
            return new EmployeeManagerViewModel(PresentButtonsEnabledStates(selectedEmployee));
        }

        private ButtonEnabledStates PresentButtonsEnabledStates(EmployeeForEmployeeListResponse selectedEmployee)
        {
            this.buttonsEnabledStates = new ButtonEnabledStates();
            buttonsEnabledStates.deleteEmployee = selectedEmployee != null;

            if (selectedEmployee != null)
            {
                PresentButtonsEnabledStatesForEmployee(buttonsEnabledStates, selectedEmployee);
            }

            return buttonsEnabledStates;
        }

        private void PresentButtonsEnabledStatesForEmployee(ButtonEnabledStates states, EmployeeForEmployeeListResponse employee)
        {
            // Implementation of this method...
        }


        private void presentButtonsEnabledStatesForEmployee(ButtonEnabledStates buttonsEnabledStates, EmployeeForEmployeeListResponse employee)
        {
            presentButtonsEnabledForPaymentType(buttonsEnabledStates, employee.paymentTypeResponse);
            presentButtonsEnabledForAffiliationType(buttonsEnabledStates, employee.affiliationTypeResponse);
        }

        private void PresentButtonsEnabledForPaymentType(ButtonEnabledStates buttonsEnabledStates, PaymentTypeResponse paymentType)
        {
            paymentType.accept(new LocalPaymentTypeResponseVisitor(buttonsEnabledStates));
        }

        private void presentButtonsEnabledForPaymentType(ButtonEnabledStates buttonsEnabledStates, PaymentTypeResponse paymentType)
        {
            paymentType.accept(new LocalPaymentTypeResponseVisitor(buttonsEnabledStates));
        }
        public void visit(CommissionedPaymentTypeResponse commissionedPaymentTypeResponse)
        {
            buttonsEnabledStates.addSalesReceipt = true;
        }

        private void presentButtonsEnabledForAffiliationType(ButtonEnabledStates buttonsEnabledStates, AffiliationTypeResponse affiliationType)
        {
            switch (affiliationType)
            {
                case AffiliationTypeResponse.NO:
                    break;
                case AffiliationTypeResponse.UNION_MEMBER:
                    buttonsEnabledStates.addServiceCharge = true;
                    break;
                default:
                    throw new Exception("not implemented");
            }
        }
    }

    public class LocalPaymentTypeResponseVisitor : PaymentTypeResponseVisitor<Object>
    {
        private readonly ButtonEnabledStates _buttonsEnabledStates;

        public LocalPaymentTypeResponseVisitor(ButtonEnabledStates buttonsEnabledStates)
        {
            _buttonsEnabledStates = buttonsEnabledStates;
        }

        public object visit(SalariedPaymentTypeResponse salariedPaymentTypeResponse)
        {
            // Logic for SalariedPaymentTypeResponse
            return new object();
        }

        public object visit(HourlyPaymentTypeResponse hourlyPaymentTypeResponse)
        {
            _buttonsEnabledStates.addTimeCard = true;

            return new object();
        }

        public object visit(CommissionedPaymentTypeResponse commissionedPaymentTypeResponse)
        {
            _buttonsEnabledStates.addSalesReceipt = true;
            return new object();
        }
    }

}




