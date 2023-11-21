namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.affiliationbutton
{
    public class AffiliationButtonUI<V> : UI<V, AffiliationButtonController> where V : AffiliationButtonView
    {
        public AffiliationButtonUI(
                AffiliationButtonController controller,
                V view
                ) : base(controller, view)
        {

        }

        public void setObservableSelectedEmployee(ObservableSelectedEmployee observableSelectedEmployee)
        {
            controller.setObservableSelectedEmployee(observableSelectedEmployee);
        }

    }


}