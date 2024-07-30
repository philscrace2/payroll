using NGuava;
using PayrollAdminAdapterGui.events;
using PayrollAdminAdapterGui.formatters.usecase.error;
using PayrollAdminAdapterGui.validation;
using PayrollAdminAdapterGui.validation.field;
using PayrollPorts.primaryAdminUseCase.factories;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.request.changemployee;
using PayrollPorts.primaryAdminUseCase.request.changemployee.affiliation;
using static PayrollAdminAdapterGui.views_controllers_uis.dialog.addunionmemberaffiliation.AddUnionMemberView;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addunionmemberaffiliation
{
    public class AddUnionMemberController<V> : AbstractDialogViewController<V, AddUnionMemberViewListener> where V : AddUnionMemberView
    {

        private EventBus eventBus;
        private int? employeeId;
        private GetEmployeeUseCaseFactory getEmployeeUseCaseFactory;
        private AddUnionMemberAffiliationUseCaseFactory addUnionMemberAffiliationUseCaseFactory;
        private UseCaseExceptionsFormatter useCaseExceptionsFormatter;
        private FieldValidationErrorPresenter fieldValidationErrorPresenter;

        //@Inject
        public AddUnionMemberController(
                EventBus eventBus,
                GetEmployeeUseCaseFactory getEmployeeUseCaseFactory,
                AddUnionMemberAffiliationUseCaseFactory addUnionMemberAffiliationUseCaseFactory,
                UseCaseExceptionsFormatter useCaseExceptionsFormatter,
                FieldValidationErrorPresenter fieldValidationErrorPresenter,
                int? employeeId
                ) : base(eventBus)
        {

            this.eventBus = eventBus;
            this.getEmployeeUseCaseFactory = getEmployeeUseCaseFactory;
            this.addUnionMemberAffiliationUseCaseFactory = addUnionMemberAffiliationUseCaseFactory;
            this.useCaseExceptionsFormatter = useCaseExceptionsFormatter;
            this.fieldValidationErrorPresenter = fieldValidationErrorPresenter;
            this.employeeId = employeeId;
        }


        public void setView(AddUnionMemberView view)
        {
            this.setView(view);
            setDefaultsToView();
        }

        private void setDefaultsToView()
        {
            AddUnionMemberView um = (AddUnionMemberView)this.GetView();
            um.setModel(toInputModel(getEmployeeName()));
        }

        private String getEmployeeName()
        {
            return getEmployeeUseCaseFactory.getEmployeeUseCase().Execute(new GetEmployeeRequest(employeeId))
            .employeeForGetEmployeeResponse.name;
        }

        private AddUnionMemberViewInputModel toInputModel(String employeeName)
        {
            AddUnionMemberViewInputModel inputModel = new AddUnionMemberViewInputModel();
            inputModel.employeeName = employeeName;
            return inputModel;
        }


        public void onAdd()
        {
            AddUnionMemberView um = (AddUnionMemberView)this.GetView();
            AddUnionMemberViewOutputModel model = um.getModel();
            try
            {
                validate(model);
                addUnionMemberAffiliationUseCaseFactory.addUnionMemberAffiliationUseCase().Execute(
                        new AddUnionMemberAffiliationRequest(employeeId, model.unionMemberId, model.weeklyDueAmount));
                onAdded();
            }
            catch (FieldValidatorException e)
            {
                um.setValidationErrorMessagesModel(fieldValidationErrorPresenter.Present(e));
            }
            catch (UnionMemberIdAlreadyExistsException e)
            {
                um.setValidationErrorMessagesModel(new ValidationSingleErrorMessageModel(useCaseExceptionsFormatter.format(e)));
            }

        }

        private void validate(AddUnionMemberViewOutputModel model)
        {
            throwIfThereAreErrors(new AddUnionMemberFieldsValidator().GetErrors(model));
        }
        private void throwIfThereAreErrors(List<FieldValidatorError> fieldValidatorErrors)
        {
            if (fieldValidatorErrors.Count != 0)
                throw new FieldValidatorException(fieldValidatorErrors);
        }

        private void onAdded()
        {
            eventBus.Post(new AffiliationChangedEvent());
            Close();
        }


        public void onCancel()
        {
            Close();
        }


        protected bool onCloseActionShouldCloseAutomatically()
        {
            return true;
        }


        protected override AddUnionMemberViewListener GetViewListener()
        {
            return (AddUnionMemberViewListener)this;
        }


        protected override bool OnCloseActionShouldCloseAutomatically()
        {
            throw new NotImplementedException();
        }

        public void setViewListener(AddUnionMemberViewListener listener)
        {
            throw new NotImplementedException();
        }

        public void setViewListener(ViewListener getViewListener)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void showIt()
        {
            throw new NotImplementedException();
        }

        public void setModel(AddUnionMemberViewInputModel viewModel)
        {
            throw new NotImplementedException();
        }

        public AddUnionMemberViewOutputModel getModel()
        {
            throw new NotImplementedException();
        }

        public void setValidationErrorMessagesModel(ValidationErrorMessagesModel errorMessagesModel)
        {
            throw new NotImplementedException();
        }

        public interface AddUnionMemberControllerFactory
        {
            AddUnionMemberController<V> create(int? employeeId);
        }
    }




}