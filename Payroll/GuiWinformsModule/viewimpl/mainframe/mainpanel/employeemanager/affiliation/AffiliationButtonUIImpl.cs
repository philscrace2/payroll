using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.affiliationbutton;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager.affiliation
{
    public class AffiliationButtonUIImpl<V> : AffiliationButtonUI<V> where V : AffiliationButtonViewImpl
    {
        public AffiliationButtonUIImpl(AffiliationButtonController<V> controller, V view) : base(controller, view)
        {
        }
    }
}
