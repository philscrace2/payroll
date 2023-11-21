namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table
{
    public abstract class EmployeeListUI<V> : UI<V, C> where V : EmployeeListView where C : Controller<>
    {
        //@Inject
        public EmployeeListUI(EmployeeListController controller, V view) : base(controller, view)
        {

        }

        public void setObservableCurrentDate(Observable<DateTime> observableCurrentDate)
        {
            controller.setObservableCurrentDate(observableCurrentDate);
        }

        public ObservableSelectedEmployee getObservableSelectedEployee()
        {
            return controller.getObservableSelectedEployee();
        }
    }

}
