namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table
{
    public interface IEmployeeListUI
    {
        void setObservableCurrentDate(Observable<DateTime> observableCurrentDate);
        ObservableSelectedEmployee getObservableSelectedEployee();
    }

    public abstract class EmployeeListUI<V> : UI<V, EmployeeListController<V>>, IEmployeeListUI where V : EmployeeListView
    {
        private readonly EmployeeListController<V> controller;

        //@Inject
        public EmployeeListUI(EmployeeListController<V> controller, V view) : base(controller, view)
        {
            this.controller = controller;
        }

        public void setObservableCurrentDate(Observable<DateTime> observableCurrentDate)
        {
            controller.setObservableCurrentDate(observableCurrentDate);
        }

        public ObservableSelectedEmployee getObservableSelectedEployee()
        {
            return controller.getObservableSelectedEployee();
        }

        public void setViewListener(EmployeeListViewListener listener)
        {
            throw new NotImplementedException();
        }

        public void setViewListener(ViewListener getViewListener)
        {
            throw new NotImplementedException();
        }

        public void setModel(EmployeeListViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }

}
