using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.affiliationbutton;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager
{
    public abstract class EmployeeManagerUI<V, EmployeeManagerController> : UI<V, EmployeeManagerController> where V : EmployeeManagerView
    {
        private EmployeeListUI<EmployeeListView> employeeListUI;

        public EmployeeManagerUI(
                EmployeeManagerController controller,
                V view,
                EmployeeListUI<EmployeeListView> employeeListUI,
                AffiliationButtonUI<AffiliationButtonView> affiliationButtonUI
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