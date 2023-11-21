namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table
{
    public abstract class EmployeeListUI<V> : UI<V, EmployeeListController> where V : EmployeeListView
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
