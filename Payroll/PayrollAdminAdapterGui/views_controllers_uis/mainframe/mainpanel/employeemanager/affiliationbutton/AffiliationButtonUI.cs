namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.affiliationbutton
{
    public abstract class AffiliationButtonUI : UI
    {
        private readonly AffiliationButtonController controller;

        public AffiliationButtonUI(
                AffiliationButtonController controller,
                AffiliationButtonView view
                ) : base(controller, view)
        {
            this.controller = controller;
        }

        public void setObservableSelectedEmployee(ObservableSelectedEmployee observableSelectedEmployee)
        {
            controller.setObservableSelectedEmployee(observableSelectedEmployee);
        }

    }


}