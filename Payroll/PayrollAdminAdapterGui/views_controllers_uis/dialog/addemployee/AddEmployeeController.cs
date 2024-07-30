using NGuava;
using PayrollAdminAdapterGui.events;
using PayrollAdminAdapterGui.formatters.usecase.error;
using PayrollAdminAdapterGui.validation;
using PayrollAdminAdapterGui.validation.field;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.requestcreator;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.validator;
using PayrollPorts.primaryAdminUseCase.exception.multiple;
using PayrollPorts.primaryAdminUseCase.factories;
using PayrollPorts.primaryAdminUseCase.request.changemployee.paymentmethod;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee
{
    public class AddEmployeeController<V> : AbstractDialogViewController<V, AddEmployeeViewListener>, AddEmployeeViewListener where V : AddEmployeeView
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
            return (AddEmployeeViewListener)this;
        }

        protected override bool OnCloseActionShouldCloseAutomatically()
        {
            return true;
        }

        public void onAddEmployee()
        {
            AddEmployeeView v = (AddEmployeeView)this.GetView();
            v.getModel().Accept(new OnAddEmployeeHandlerExecutor(this));
        }

        public void onCancel()
        {
            Close();
        }

        public class OnAddEmployeeHandlerExecutor : IEmployeeViewModelVisitor
        {
            private readonly AddEmployeeController<V> addEmployeeController;

            public OnAddEmployeeHandlerExecutor(AddEmployeeController<V> addEmployeeController)
            {
                this.addEmployeeController = addEmployeeController;
            }
            public void Visit(SalariedEmployeeViewModel salariedEmployeeViewModel)
            {
                new OnAddSalariedEmployeeHandler(addEmployeeController).OnAddEmployee(salariedEmployeeViewModel);
            }

            public void Visit(HourlyEmployeeViewModel hourlyEmployeeViewModel)
            {
                new OnAddHourlyEmployeeHandler(addEmployeeController).OnAddEmployee(hourlyEmployeeViewModel);
            }

            public void Visit(CommissionedEmployeeViewModel commissionedEmployeeViewModel)
            {
                new OnAddCommissionedEmployeeHandler(addEmployeeController).OnAddEmployee(commissionedEmployeeViewModel);
            }
        }

        public class ExecuteChangePaymentMethodUseCaseExecutor : IPaymentMethodVisitor<object>
        {
            private readonly AddEmployeeController<V> controller;
            private int? employeeId;

            public ExecuteChangePaymentMethodUseCaseExecutor(AddEmployeeController<V> controller, int? employeeId)
            {
                this.controller = controller;
                this.employeeId = employeeId;
            }

            //public object Visit(PayrollEntities.paymentmethod.PaymasterPaymentMethod paymasterPaymentMethod)
            //{
            //    return this.controller.changePaymentMethodUseCaseFactory.changeToPaymasterPaymentMethodUseCase();
            //}

            //public object Visit(PayrollEntities.paymentmethod.DirectPaymentMethod directPaymentMethod)
            //{
            //    this.controller.changePaymentMethodUseCaseFactory.changeToDirectPaymentMethodUseCase().Execute(
            //        new ChangeToDirectPaymentMethodRequest(this.employeeId, directPaymentMethod.getAccountNumber()));
            //    return new object();
            //}

            public object Visit(PaymasterPaymentMethod paymentMethod)
            {
                return this.controller.changePaymentMethodUseCaseFactory.changeToPaymasterPaymentMethodUseCase();
            }

            public object Visit(DirectPaymentMethod directPaymentMethod)
            {
                this.controller.changePaymentMethodUseCaseFactory.changeToDirectPaymentMethodUseCase().Execute(
                    new ChangeToDirectPaymentMethodRequest(this.employeeId, directPaymentMethod.AccountNumber));
                return new object();
            }
        }
        public abstract class OnAddEmployeeHandler<T> where T : EmployeeViewModel
        {
            private readonly AddEmployeeController<V> addEmployeeController;

            public OnAddEmployeeHandler(AddEmployeeController<V> addEmployeeController)
            {
                this.addEmployeeController = addEmployeeController;
            }
            public void OnAddEmployee(T model)
            {
                try
                {
                    Validate(model);
                    ExecuteAddEmployeeUseCase(model);
                    //model.PaymentMethod.Accept((new ExecuteChangePaymentMethodUseCaseExecutor(addEmployeeController, model.EmployeeId)));
                    addEmployeeController.eventBus.Post(new AddedEmployeeEvent(model.EmployeeId.Value, model.Name));
                    addEmployeeController.Close();
                }
                catch (FieldValidatorException e)
                {
                    AddEmployeeView v = (AddEmployeeView)addEmployeeController.GetView();
                    v.setModel(addEmployeeController.fieldValidationErrorPresenter.Present(e));
                }
                catch (MultipleErrorsUseCaseException<Exception> e)
                {
                    AddEmployeeView v = (AddEmployeeView)addEmployeeController.GetView();

                    v.setModel(new ValidationErrorMessagesModel(addEmployeeController.addEmployeeUseCaseErrorFormatter.FormatAll(new List<string>())));
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





        // ...

        public class OnAddSalariedEmployeeHandler : OnAddEmployeeHandler<SalariedEmployeeViewModel>
        {
            private readonly AddEmployeeController<V> addEmployeeController;
            public OnAddSalariedEmployeeHandler(AddEmployeeController<V> addEmployeeController) : base(addEmployeeController)
            {
                this.addEmployeeController = addEmployeeController;
            }

            protected override List<FieldValidatorError> GetValidationErrors(SalariedEmployeeViewModel model)
            {
                // Assuming AddSalariedEmployeeFieldsValidator is a class that validates the fields of a salaried employee model
                return new AddSalariedEmployeeFieldsValidator().GetErrors(model);
            }

            protected override void ExecuteAddEmployeeUseCase(SalariedEmployeeViewModel model)
            {
                // Assuming SalariedRequestCreator is a class that creates a request object from a salaried employee model
                var request = new SalariedRequestCreator().toRequest(model);
                this.addEmployeeController.addEmployeeUseCaseFactory.addSalariedEmployeeUseCase().Execute(request);
            }
        }

        private class OnAddHourlyEmployeeHandler : OnAddEmployeeHandler<HourlyEmployeeViewModel>
        {
            private readonly AddEmployeeController<V> addEmployeeController;
            public OnAddHourlyEmployeeHandler(AddEmployeeController<V> addEmployeeController) : base(addEmployeeController)
            {
                this.addEmployeeController = addEmployeeController;
            }

            protected override List<FieldValidatorError> GetValidationErrors(HourlyEmployeeViewModel model)
            {
                // Similar to the salaried employee, but for hourly employees
                return new AddHourlyEmployeeFieldsValidator().GetErrors(model);
            }

            protected override void ExecuteAddEmployeeUseCase(HourlyEmployeeViewModel model)
            {
                var request = new HourlyRequestCreator().toRequest(model);
                this.addEmployeeController.addEmployeeUseCaseFactory.addHourlyEmployeeUseCase().Execute(request);
            }
        }

        public class OnAddCommissionedEmployeeHandler : OnAddEmployeeHandler<CommissionedEmployeeViewModel>
        {
            private readonly AddEmployeeController<V> addEmployeeController;
            public OnAddCommissionedEmployeeHandler(AddEmployeeController<V> addEmployeeController) : base(addEmployeeController)
            {
                this.addEmployeeController = addEmployeeController;
            }

            protected override List<FieldValidatorError> GetValidationErrors(CommissionedEmployeeViewModel model)
            {
                return new AddCommissionedEmployeeFieldsValidator().GetErrors(model);
            }

            protected override void ExecuteAddEmployeeUseCase(CommissionedEmployeeViewModel model)
            {
                addEmployeeController.addEmployeeUseCaseFactory.addCommissionedEmployeeUseCase().Execute(new CommissionedRequestCreator().toRequest(model));
            }
        }

        public void setViewListener(AddEmployeeViewListener listener)
        {
            throw new NotImplementedException();
        }

        public void setViewListener(ViewListener getViewListener)
        {
            throw new NotImplementedException();
        }

        public void showIt()
        {

        }

        public EmployeeViewModel getModel()
        {
            throw new NotImplementedException();
        }

        public void setModel(ValidationErrorMessagesModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void accept(EmployeeViewModelVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}

