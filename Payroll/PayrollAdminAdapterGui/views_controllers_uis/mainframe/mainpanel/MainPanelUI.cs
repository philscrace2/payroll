using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel
{
    public abstract class MainPanelUI<V> : UI<V, MainPanelController<V>> where V : MainPanelView
    {
        //@Inject
        public MainPanelUI(
                MainPanelController<V> controller,
                V view,
                IEmployeeManagerUI employeeManagerUI,
                IPayUI payUI
                ) : base(controller, view)
        {


            employeeManagerUI.setObservableCurrentDate(controller.getObservableCurrentDate());
            payUI.setObservableCurrentDate(controller.getObservableCurrentDate());
            initialize();
        }

        //@Inject
        private void initialize()
        {
            controller.setDefaultModelToView();
        }

    }


}