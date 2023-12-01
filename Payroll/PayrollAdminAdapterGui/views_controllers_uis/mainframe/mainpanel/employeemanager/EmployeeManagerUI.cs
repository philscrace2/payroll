using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.affiliationbutton;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager
{
    public interface IEmployeeManagerUI
    {
        void setObservableCurrentDate(Observable<DateTime> observableCurrentDate);
    }

    public abstract class EmployeeManagerUI<V> : UI<V, EmployeeManagerController<V>>, IEmployeeManagerUI where V : EmployeeManagerView
    {
        private readonly IEmployeeListUI employeeListUi;

        public EmployeeManagerUI(
                EmployeeManagerController<V> controller,
                V view,
                IEmployeeListUI employeeListUI,
                IAffiliationButtonUI affiliationButtonUI
                ) : base(controller, view)
        {
            this.employeeListUi = employeeListUI;


            controller.setObservableSelectedEmployee(employeeListUI.getObservableSelectedEployee());
            affiliationButtonUI.setObservableSelectedEmployee(employeeListUI.getObservableSelectedEployee());
        }

        public void setObservableCurrentDate(Observable<DateTime> observableCurrentDate)
        {
            employeeListUi.setObservableCurrentDate(observableCurrentDate);
        }

    }

}