using PayrollAdminAdapterGui.events;
using PayrollPorts.primaryAdminUseCase.factories;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;
using static PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table.EmployeeListPresenter;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table
{
    public class EmployeeListController<V> : AbstractController<V, EmployeeListViewListener>, ChangeListener<DateTime> where V : EmployeeListView
    {
        private EmployeeListUseCaseFactory useCaseFactory;
        private EmployeeListPresenterFactory employeeListPresenterFactory;

        private Observable<DateTime> observableCurrentDate;
        private List<EmployeeForEmployeeListResponse> employees;
        private ObservableSelectedEmployeeValue observableSelectedEmployee = new ObservableSelectedEmployeeValue();

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
            //TODO PHIL SCRACE
            //if (employeeIndex.HasValue)
            //{
            //    observableSelectedEmployee.Value = employees[employeeIndex.Value];
            //}
            //else
            //{
            //    observableSelectedEmployee.Value = null; // or a default value
            //}

        }

        private void update()
        {
            EmployeeListResponse employeeListResponse = useCaseFactory.employeeListUseCase().Execute(new EmployeeListRequest(observableCurrentDate.get()));
            employees = employeeListResponse.employees;
            EmployeeListView elv = (EmployeeListView)this.GetView();
            elv.setModel(employeeListPresenterFactory.of(observableCurrentDate.get(), employeeListResponse).toViewModel());
        }

        protected override ViewListener GetViewListener()
        {
            return (EmployeeListViewListener)this;
        }

        public void onSelectionChanged(int? employeeIndex)
        {
            throw new NotImplementedException();
        }
    }

    public class ObservableSelectedEmployeeValue : ObservableValue<EmployeeForEmployeeListResponse>, ObservableSelectedEmployee
    {
        public ObservableSelectedEmployeeValue() : base()
        {

        }

        public void addChangeListener(Action value)
        {
            throw new NotImplementedException();
        }
    }

}