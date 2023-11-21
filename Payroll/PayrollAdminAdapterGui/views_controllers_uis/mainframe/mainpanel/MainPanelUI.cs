namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel
{
    public abstract class MainPanelUI<V> : UI<V, MainPanelController> where V : MainPanelView
    {

        //@Inject
        public MainPanelUI(
                MainPanelController controller,
                V view,
                EmployeeManagerUI employeeManagerUI,
                PayUI payUI
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