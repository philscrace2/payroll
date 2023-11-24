using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.affiliationbutton;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager
{
    public abstract class EmployeeManagerUI<V, C> : UI<V, C> where V : AddEmployeeView where C : EmployeeManagerController<V>, Controller<V>
    {
        private EmployeeListUI<EmployeeListView> employeeListUI;

        public EmployeeManagerUI(
                C controller,
                V view,
                EmployeeListUI<EmployeeListView> employeeListUI,
                AffiliationButtonUI<AffiliationButtonView, AffiliationButtonController<AffiliationButtonView>> affiliationButtonUI
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