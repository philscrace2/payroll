using PayrollAdminAdapterGui.events;
using PayrollAdminAdapterGui.formatters.controller.msg;
using PayrollAdminAdapterGui.validation.field;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.common.confirm;
using PayrollPorts.primaryAdminUseCase.factories;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.request.hourly;


namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addtimecard
{
    public class AddTimeCardController<V> : AbstractDialogViewController<V, AddTimeCardViewListener> where V : AddTimeCardView
    {
        private EventBus eventBus;
        private int employeeId;
        private GetEmployeeUseCaseFactory getEmployeeUseCaseFactory;
        private AddTimeCardUseCaseFactory addTimeCardUseCaseFactory;
        private UpdateTimeCardUseCaseFactory updateTimeCardUseCaseFactory;
        //Provider is a ninject class
        private ConfirmDialogUI confirmDialogUIProvider;
        private ConfirmMessageFormatter confirmMessageFormatter;
        private FieldValidationErrorPresenter fieldValidationErrorPresenter;

        //@Inject
        public AddTimeCardController(
                EventBus eventBus,
                GetEmployeeUseCaseFactory getEmployeeUseCaseFactory,
                AddTimeCardUseCaseFactory addTimeCardUseCaseFactory,
                UpdateTimeCardUseCaseFactory updateTimeCardUseCaseFactory,
                ConfirmDialogUI confirmDialogUIProvider,
                ConfirmMessageFormatter confirmMessageFormatter,
                FieldValidationErrorPresenter fieldValidationErrorPresenter,
                 int employeeId
                ) : base(eventBus)
        {

            this.eventBus = eventBus;
            this.getEmployeeUseCaseFactory = getEmployeeUseCaseFactory;
            this.addTimeCardUseCaseFactory = addTimeCardUseCaseFactory;
            this.updateTimeCardUseCaseFactory = updateTimeCardUseCaseFactory;
            this.confirmDialogUIProvider = confirmDialogUIProvider;
            this.confirmMessageFormatter = confirmMessageFormatter;
            this.fieldValidationErrorPresenter = fieldValidationErrorPresenter;
            this.employeeId = employeeId;
        }
        protected override bool OnCloseActionShouldCloseAutomatically()
        {
            return true;
        }


        public void setView(AddTimeCardView view)
        {
            setDefaultsToView();
        }

        private void setDefaultsToView()
        {
            AddTimeCardView v = (AddTimeCardView)this.GetView();
            v.setModel(toInputModel(getEmployeeName(), getDefaultDate()));
        }

        private String getEmployeeName()
        {
            return getEmployeeUseCaseFactory.getEmployeeUseCase().Execute(new GetEmployeeRequest(employeeId))
                    .employeeForGetEmployeeResponse.name;
        }

        private DateTime getDefaultDate()
        {
            return DateTime.Now;
        }

        private AddTimeCardViewInputModel toInputModel(String employeeName, DateTime defaultDate)
        {
            AddTimeCardViewInputModel inputModel = new AddTimeCardViewInputModel();
            inputModel.employeeName = employeeName;
            inputModel.defaultDate = defaultDate;
            return inputModel;
        }
        public void onCancel()
        {
            Close();
        }

        private void validate(AddTimeCardViewOutputModel model)
        {
            throwIfThereAreErrors(new AddTimeCardFieldsValidator().GetErrors(model));
        }

        protected override AddTimeCardViewListener GetViewListener()
        {
            return (AddTimeCardViewListener)this;
        }

        private void OnTimeCardAlreadyExists(AddTimeCardViewOutputModel model)
        {
            //confirmDialogUIProvider.show(confirmMessageFormatter.timeCardAlreadyExists, new ConfirmDialogListener(() =>
            //{
            //    updateTimeCardUseCaseFactory.UpdateTimeCardUseCase().Execute(ToUpdateRequest(model));
            //    OnUpdated(model);

            //}));

        }
        public void onAdd()
        {
            AddTimeCardView v = (AddTimeCardView)this.GetView();
            AddTimeCardViewOutputModel model = v.getModel();
            try
            {
                validate(model);
                addTimeCardUseCaseFactory.addTimeCardUseCase().Execute(toAddRequest(model));
                onAdded(model);
            }
            catch (FieldValidatorException e)
            {
                AddTimeCardView addTimeCardView = (AddTimeCardView)this.GetView();
                addTimeCardView.setValidationErrorMessagesModel(fieldValidationErrorPresenter.Present(e));
            }
            catch (TimeCardAlreadyExistsException e)
            {
                OnTimeCardAlreadyExists(model);
            }
        }
        private void onAdded(AddTimeCardViewOutputModel model)
        {
            eventBus.Post(new AddedTimeCardEvent(getEmployeeName(), model.date));
            Close();
        }

        private AddTimeCardRequest toAddRequest(AddTimeCardViewOutputModel model)
        {
            return new AddTimeCardRequest(employeeId, model.date, model.workingHourQty);
        }

        private void throwIfThereAreErrors(List<FieldValidatorError> fieldValidatorErrors)
        {
            if (fieldValidatorErrors.Count != 0)
                throw new FieldValidatorException(fieldValidatorErrors);
        }

        public interface AddTimeCardControllerFactory
        {
            AddTimeCardController<V> create(int employeeId);
        }

    }


}