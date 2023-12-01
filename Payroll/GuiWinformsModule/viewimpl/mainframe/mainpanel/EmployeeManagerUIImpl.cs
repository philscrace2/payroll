using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager.affiliation;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel
{
    public class EmployeeManagerUIImpl<V> : EmployeeManagerUI<V> where V : EmployeeManagerView
    {

        //@Inject
        public EmployeeManagerUIImpl(
            EmployeeManagerController<V> controller,
            EmployeeListUIImpl employeeListUIImpl,
            AffiliationButtonUIImpl<AffiliationButtonViewImpl> affiliationButtonUIImpl
        ) : base(controller, (V)(new EmployeeManagerPanel(employeeListUIImpl.View, affiliationButtonUIImpl.getView()) as EmployeeManagerView), employeeListUIImpl, affiliationButtonUIImpl)
        {

        }

    }
}
