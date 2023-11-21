using PayrollAdminAdapterGui.formatters.usecase.error;
using PayrollAdminAdapterGui.validation.field;
using PayrollEntities.paymentmethod;
using PayrollPorts.primaryAdminUseCase.factories;
using PayrollPorts.primaryAdminUseCase.request.changemployee.paymentmethod;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee
{
    public class AddEmployeeController : AbstractDialogViewController<AddEmployeeView, AddEmployeeViewListener>, AddEmployeeViewListener
    {
        private AddEmployeeUseCaseFactory addEmployeeUseCaseFactory;
        private ChangeToAbstractPaymentMethodUseCaseFactory changePaymentMethodUseCaseFactory;
        private EventBus eventBus;
        private AddEmployeeUseCaseErrorFormatter addEmployeeUseCaseErrorFormatter;
        private FieldValidationErrorPresenter fieldValidationErrorPresenter;

        public AddEmployeeController(
            AddEmployeeUseCaseFactory addEmployeeUseCaseFactory,
            ChangeToAbstractPaymentMethodUseCaseFactory changePaymentMethodUseCaseFactory,
            AddEmployeeUseCaseErrorFormatter addEmployeeUseCaseErrorFormatter,
            FieldValidationErrorPresenter fieldValidationErrorPresenter,
            EventBus eventBus
            ) : base(eventBus)
        {
            this.addEmployeeUseCaseFactory = addEmployeeUseCaseFactory;
            this.changePaymentMethodUseCaseFactory = changePaymentMethodUseCaseFactory;
            this.addEmployeeUseCaseErrorFormatter = addEmployeeUseCaseErrorFormatter;
            this.fieldValidationErrorPresenter = fieldValidationErrorPresenter;
            this.eventBus = eventBus;
        }

        protected override AddEmployeeViewListener GetViewListener()
        {
            return this;
        }

        protected override bool OnCloseActionShouldCloseAutomatically()
        {
            return true;
        }

        public void onAddEmployee()
        {
            GetView().getModel().accept(new OnAddEmployeeHandlerExecutor(this));
        }

        public void onCancel()
        {
            Close();
        }

        public class OnAddEmployeeHandlerExecutor : EmployeeViewModelVisitor
        {
            private AddEmployeeController controller;
            public OnAddEmployeeHandlerExecutor(AddEmployeeController controller)
            {
                this.controller = controller;
            }
            public void visit(SalariedEmployeeViewModel salariedEmployeeViewModel)
            {
                new OnAddSalariedEmployeeHandler().OnAddEmployee(salariedEmployeeViewModel);
            }

            public void visit(HourlyEmployeeViewModel hourlyEmployeeViewModel)
            {
                new OnAddHourlyEmployeeHandler().OnAddEmployee(hourlyEmployeeViewModel);
            }

            public void visit(CommissionedEmployeeViewModel commissionedEmployeeViewModel)
            {
                new OnAddCommissionedEmployeeHandler().OnAddEmployee(commissionedEmployeeViewModel);
            }
        }

        public abstract class OnAddEmployeeHandler<T> where T : EmployeeViewModel
        {
            public void OnAddEmployee(T model)
            {
                try
                {
                    Validate(model);
                    ExecuteAddEmployeeUseCase(model);
                    model.paymentMethod.accept(new ExecuteChangePaymentMethodUseCaseExecutor(model.employeeId.Value));
                    eventBus.Post(new AddedEmployeeEvent(model.employeeId.Value, model.name));
                    Close();
                }
                catch (FieldValidatorException e)
                {
                    View.SetModel(fieldValidationErrorPresenter.Present(e));
                }
                catch (MultipleErrorsUseCaseException e)
                {
                    View.SetModel(new ValidationErrorMessagesModel(addEmployeeUseCaseErrorFormatter.FormatAll(e.Errors)));
                }
            }

            private void Validate(T model)
            {
                var errors = GetValidationErrors(model);
                if (errors.Any())
                    throw new FieldValidatorException(errors);
            }

            protected abstract List<FieldValidatorError> GetValidationErrors(T model);
            protected abstract void ExecuteAddEmployeeUseCase(T model);
        }

        private class ExecuteChangePaymentMethodUseCaseExecutor : IPaymentMethodVisitor<Void>
        {
            private int employeeId;

            public ExecuteChangePaymentMethodUseCaseExecutor(int employeeId)
            {
                this.employeeId = employeeId;
            }

            public void visit(PaymasterPaymentMethod paymentMethod)
            {
                changePaymentMethodUseCaseFactory.ChangeToPaymasterPaymentMethodUseCase();
            }

            public void visit(DirectPaymentMethod paymentMethod)
            {
                changePaymentMethodUseCaseFactory.ChangeToDirectPaymentMethodUseCase().Execute(
                    new ChangeToDirectPaymentMethodRequest(employeeId, paymentMethod.AccountNumber));

            }
        }

        // ...

        public class OnAddSalariedEmployeeHandler : OnAddEmployeeHandler<SalariedEmployeeViewModel>
        {
            public OnAddSalariedEmployeeHandler() { }

            protected override List<FieldValidatorError> GetValidationErrors(SalariedEmployeeViewModel model)
            {
                // Assuming AddSalariedEmployeeFieldsValidator is a class that validates the fields of a salaried employee model
                return new AddSalariedEmployeeFieldsValidator().GetErrors(model);
            }

            protected override void ExecuteAddEmployeeUseCase(SalariedEmployeeViewModel model)
            {
                // Assuming SalariedRequestCreator is a class that creates a request object from a salaried employee model
                var request = new SalariedRequestCreator().ToRequest(model);
                controller.addEmployeeUseCaseFactory.AddSalariedEmployeeUseCase().Execute(request);
            }
        }

        private class OnAddHourlyEmployeeHandler : OnAddEmployeeHandler<HourlyEmployeeViewModel>
        {
            public OnAddHourlyEmployeeHandler() { }

            protected override List<FieldValidatorError> GetValidationErrors(HourlyEmployeeViewModel model)
            {
                // Similar to the salaried employee, but for hourly employees
                return new AddHourlyEmployeeFieldsValidator().GetErrors(model);
            }

            protected override void ExecuteAddEmployeeUseCase(HourlyEmployeeViewModel model)
            {
                var request = new HourlyRequestCreator().ToRequest(model);
                controller.addEmployeeUseCaseFactory.AddHourlyEmployeeUseCase().Execute(request);
            }
        }

        public class OnAddCommissionedEmployeeHandler : OnAddEmployeeHandler<CommissionedEmployeeViewModel>
        {
            public OnAddCommissionedEmployeeHandler() { }

            protected override List<FieldValidatorError> GetValidationErrors(CommissionedEmployeeViewModel model)
            {
                return new AddCommissionedEmployeeFieldsValidator().getErrors(model);
            }

            protected void ExecuteAddEmployeeUseCase(CommissionedEmployeeViewModel model)
            {
                addEmployeeUseCaseFactory.addCommissionedEmployeeUseCase().execute(new CommissionedRequestCreator().toRequest(model));
            }
        }

    }
}

