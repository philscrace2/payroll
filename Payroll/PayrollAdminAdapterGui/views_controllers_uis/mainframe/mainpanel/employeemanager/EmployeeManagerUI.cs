using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.affiliationbutton;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager
{
    public abstract class EmployeeManagerUI : UI
    {
        private EmployeeListUI employeeListUI;

        public EmployeeManagerUI(
                EmployeeManagerController controller,
                View view,
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