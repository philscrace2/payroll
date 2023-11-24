using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel
{
    public abstract class MainPanelUI : UI
    {
        private readonly MainPanelController controller;
        private readonly MainPanelView view;
        private readonly EmployeeManagerUI<AddEmployeeView, object> employeeManagerUi;
        private readonly PayUI payUi;

        //@Inject
        public MainPanelUI(
                MainPanelController controller,
                MainPanelView view,
                EmployeeManagerUI<AddEmployeeView, object> employeeManagerUI,
                PayUI payUI
                ) : base(controller, view)
        {
            this.controller = controller;
            this.view = view;
            employeeManagerUi = employeeManagerUI;
            payUi = payUI;

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