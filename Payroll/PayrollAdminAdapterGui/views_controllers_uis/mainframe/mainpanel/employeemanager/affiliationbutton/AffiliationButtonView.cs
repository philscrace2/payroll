namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.affiliationbutton
{
    public interface AffiliationButtonView : ControlView<AffiliationButtonViewListener>, ModelConsumer<AffiliationButtonViewModel>
    { }

    public interface AffiliationButtonViewListener
    {
        void onActionPerformed();
    }

    public class AffiliationButtonViewModel
    {
        public bool enabled;
        public string buttonText;
    }

}

