namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table
{
    public abstract class EmployeeListUI : UI, EmployeeListView
    {
        private readonly EmployeeListController controller;

        //@Inject
        public EmployeeListUI(EmployeeListController controller, EmployeeListView view) : base(controller, view)
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
