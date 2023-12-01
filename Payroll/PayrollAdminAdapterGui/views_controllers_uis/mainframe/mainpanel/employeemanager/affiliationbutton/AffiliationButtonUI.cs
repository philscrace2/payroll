namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.affiliationbutton
{
    public interface IAffiliationButtonUI
    {
        void setObservableSelectedEmployee(ObservableSelectedEmployee observableSelectedEmployee);
    }

    public abstract class AffiliationButtonUI<V> : UI<V, AffiliationButtonController<V>>, IAffiliationButtonUI where V : AffiliationButtonView
    {
        private readonly AffiliationButtonController<V> controller;

        public AffiliationButtonUI(
                AffiliationButtonController<V> controller,
                V view
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