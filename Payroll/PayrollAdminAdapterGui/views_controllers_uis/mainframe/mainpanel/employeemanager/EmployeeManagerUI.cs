namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager
{
    public abstract class EmployeeManagerUI<V> : UI<V, EmployeeManagerController> where V : EmployeeManagerView
    {
        private EmployeeListUI employeeListUI;

        public EmployeeManagerUI(
                EmployeeManagerController controller,
                V view,
                EmployeeListUI employeeListUI,
                AffiliationButtonUI affiliationButtonUI
                ) : base(controller, view)
        {

            this.employeeListUI = employeeListUI;
            controller.setObservableSelectedEmployee(employeeListUI.getObservableSelectedEployee());
            affiliationButtonUI.setObservableSelectedEmployee(employeeListUI.getObservableSelectedEployee());
        }

        public void setObservableCurrentDate(Observable<DateTime> observableCurrentDate)
        {
            employeeListUI.setObservableCurrentDate(observableCurrentDate);
        }

    }

}