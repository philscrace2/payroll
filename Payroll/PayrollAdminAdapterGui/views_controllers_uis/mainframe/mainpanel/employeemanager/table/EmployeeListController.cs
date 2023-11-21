using PayrollAdminAdapterGui.events;
using PayrollPorts.primaryAdminUseCase.factories;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;
using static PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table.EmployeeListPresenter;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table
{
    public class EmployeeListController : AbstractController<EmployeeListView, EmployeeListViewListener>, ChangeListener<DateTime>
    {
        private EmployeeListUseCaseFactory useCaseFactory;
        private EmployeeListPresenterFactory employeeListPresenterFactory;

        private Observable<DateTime> observableCurrentDate;
        private List<EmployeeForEmployeeListResponse> employees;
        private ObservableSelectedEployeeValue observableSelectedEmployee = new ObservableSelectedEployeeValue();

        //@Inject
        public EmployeeListController(
                EmployeeListUseCaseFactory useCaseFactory,
                EventBus eventBus,
                EmployeeListPresenterFactory employeeListPresenterFactory
                )
        {
            this.useCaseFactory = useCaseFactory;
            this.employeeListPresenterFactory = employeeListPresenterFactory;
            eventBus.Register(this);
        }

        public void setObservableCurrentDate(Observable<DateTime> observableCurrentDate)
        {
            this.observableCurrentDate = observableCurrentDate;
            observableCurrentDate.addChangeListener(this);
        }

        public ObservableSelectedEmployee getObservableSelectedEployee()
        {
            return observableSelectedEmployee;
        }

        //@Subscribe
        public void onEmployeeChanged(EmployeeChangedEvent e)
        {
            update();
        }

        //@Override
        public void onChanged(DateTime currentDate)
        {
            update();
        }

        //@Override
        public void OnSelectionChanged(int? employeeIndex)
        {
            observableSelectedEmployee = employeeIndex.Value
                ? employees[employeeIndex.Value]
                : null;
        }

        private void update()
        {
            EmployeeListResponse employeeListResponse = useCaseFactory.employeeListUseCase().Execute(new EmployeeListRequest(observableCurrentDate.get()));
            employees = employeeListResponse.employees;
            GetView().setModel(employeeListPresenterFactory.of(observableCurrentDate.get(), employeeListResponse).toViewModel());
        }

        protected EmployeeListViewListener GetViewListener()
        {
            return this;
        }
    }

    public class ObservableSelectedEployeeValue : ObservableValue<EmployeeForEmployeeListResponse>, ObservableSelectedEmployee
    {
        public ObservableSelectedEployeeValue() : base()
        {

        }
    }

}