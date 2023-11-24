namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.affiliationbutton
{
    public abstract class AffiliationButtonUI<V, C> : UI<V, C> where V : AffiliationButtonView where C : AffiliationButtonController<V>
    {
        public AffiliationButtonUI(
                C controller,
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