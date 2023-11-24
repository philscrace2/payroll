using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel
{
    public abstract class MainPanelUI<V> : UI<V, MainPanelController> where V : MainPanelView
    {

        //@Inject
        public MainPanelUI(
                MainPanelController controller,
                V view,
                EmployeeManagerUI<AddEmployeeView, object> employeeManagerUI,
                PayUI<PayView> payUI
                ) : base(controller, view)
        {

            employeeManagerUI.setObservableCurrentDate(controller.getObservableCurrentDate());
            payUI.setObservableCurrentDate(controller.getObservableCurrentDate());
        }

        //@Inject
        private void initialize()
        {
            controller.setDefaultModelToView();
        }

    }


}