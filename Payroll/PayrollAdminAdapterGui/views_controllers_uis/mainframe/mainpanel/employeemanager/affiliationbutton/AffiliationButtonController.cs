using PayrollAdminAdapterGui.events;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addunionmemberaffiliation;
using PayrollPorts.primaryAdminUseCase.factories;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.request.changemployee.affiliation;
using PayrollPorts.primaryAdminUseCase.response;
using PayrollPorts.primaryAdminUseCase.response.employee;


namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.affiliationbutton
{
    public class AffiliationButtonController : AbstractController<AffiliationButtonView, AffiliationButtonViewListener>, ChangeListener<EmployeeForEmployeeListResponse>
    {
        private EventBus eventBus;
        private ObservableSelectedEmployee observableSelectedEmployee;
        private GetUnionMemberAffiliationUseCaseFactory getUnionMemberAffiliationUseCaseFactory;
        private RemoveUnionMemberAffiliationUseCaseFactory removeUnionMemberAffiliationUseCaseFactory;
        private AddUnionMemberUIFactory addUnionMemberUIFactory;

        //@Inject
        public AffiliationButtonController(
                GetUnionMemberAffiliationUseCaseFactory getUnionMemberAffiliationUseCaseFactory,
                RemoveUnionMemberAffiliationUseCaseFactory removeUnionMemberAffiliationUseCaseFactory,
                AddUnionMemberUIFactory addUnionMemberUIFactory,
                EventBus eventBus
                )
        {
            this.getUnionMemberAffiliationUseCaseFactory = getUnionMemberAffiliationUseCaseFactory;
            this.removeUnionMemberAffiliationUseCaseFactory = removeUnionMemberAffiliationUseCaseFactory;
            this.addUnionMemberUIFactory = addUnionMemberUIFactory;
            this.eventBus = eventBus;
        }


        protected override ViewListener GetViewListener()
        {
            return (ViewListener)this;
        }


        public void onActionPerformed()
        {
            EmployeeForEmployeeListResponse employee = observableSelectedEmployee.get();
            Action action = toAction(employee.affiliationTypeResponse);
            action.execute(employee);
            update();
        }

        public void setObservableSelectedEmployee(ObservableSelectedEmployee observableSelectedEployee)
        {
            this.observableSelectedEmployee = observableSelectedEployee;
            observableSelectedEployee.addChangeListener(this);
        }


        public void onChanged(EmployeeForEmployeeListResponse employee)
        {
            update();
        }

        private void update()
        {
            AffiliationButtonView bv = (AffiliationButtonView)this.GetView();
            bv.setModel(Present(observableSelectedEmployee.get()));
        }

        private AffiliationButtonViewModel Present(EmployeeForEmployeeListResponse employee)
        {
            AffiliationButtonViewModel model = new AffiliationButtonViewModel();
            model.enabled = employee != null;
            model.buttonText = employee != null ? ToButtonText(employee.affiliationTypeResponse) : "Affiliation...";
            return model;
        }

        private String ToButtonText(AffiliationTypeResponse affiliationType)
        {
            return toAction(affiliationType).getButtonText();
        }

        private Action toAction(AffiliationTypeResponse affiliationType)
        {
            switch (affiliationType)
            {
                case AffiliationTypeResponse.UNION_MEMBER:
                    return new RemoveUnionMemberAction(this.removeUnionMemberAffiliationUseCaseFactory, getUnionMemberAffiliationUseCaseFactory, eventBus);
                case AffiliationTypeResponse.NO:
                    return new ChangeToUnionMemberAction(this.addUnionMemberUIFactory);
                default:
                    throw new Exception("not implemented");
            }
        }

        public class RemoveUnionMemberAction : Action
        {
            private readonly RemoveUnionMemberAffiliationUseCaseFactory removeUnionMemberAffiliationUseCaseFactory;
            private readonly GetUnionMemberAffiliationUseCaseFactory getUnionMemberAffiliationUseCaseFactory;
            private readonly EventBus eventBus;

            public RemoveUnionMemberAction(RemoveUnionMemberAffiliationUseCaseFactory removeUnionMemberAffiliationUseCaseFactory, GetUnionMemberAffiliationUseCaseFactory getUnionMemberAffiliationUseCaseFactory, EventBus eventBus)
            {
                this.removeUnionMemberAffiliationUseCaseFactory = removeUnionMemberAffiliationUseCaseFactory;
                this.getUnionMemberAffiliationUseCaseFactory = getUnionMemberAffiliationUseCaseFactory;
                this.eventBus = eventBus;
            }
            public void execute(EmployeeForEmployeeListResponse e)
            {
                removeUnionMemberAffiliationUseCaseFactory.removeUnionMemberAffiliationUseCase().Execute(
                    new RemoveUnionMemberAffiliationRequest(getUnionMemberAffiliation(e).unionMemberId));
                eventBus.Post(new AffiliationChangedEvent());
            }
            private GetUnionMemberAffiliationResponse getUnionMemberAffiliation(EmployeeForEmployeeListResponse e)
            {
                return getUnionMemberAffiliationUseCaseFactory.getUnionMemberAffiliationUseCase()
                    .Execute(new GetUnionMemberAffiliationRequest(e.id));
            }

            public String getButtonText()
            {
                return "Remove Affiliation";
            }

        }
    }



    public interface Action
    {
        void execute(EmployeeForEmployeeListResponse e);
        String getButtonText();
    }

    public class ChangeToUnionMemberAction : Action
    {
        private AddUnionMemberUIFactory addUnionMemberUIFactory = null;

        public ChangeToUnionMemberAction(AddUnionMemberUIFactory addUnionMemberUIFactory)
        {
            this.addUnionMemberUIFactory = addUnionMemberUIFactory;
        }
        public void execute(EmployeeForEmployeeListResponse e)
        {
            addUnionMemberUIFactory.create(e.id).show();
        }

        public String getButtonText()
        {
            return "Change to Union Member..";
        }

    }
}