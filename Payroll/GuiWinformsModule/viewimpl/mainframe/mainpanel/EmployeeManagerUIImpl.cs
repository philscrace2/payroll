using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager.affiliation;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel
{
    public class EmployeeManagerUIImpl : EmployeeManagerUI
    {

        //@Inject
        public EmployeeManagerUIImpl(
            EmployeeManagerController controller,
            EmployeeListUIImpl employeeListUIImpl,
            AffiliationButtonUIImpl affiliationButtonUIImpl
        ) : base(controller, new EmployeeManagerPanel(employeeListUIImpl.View, (AffiliationButtonViewImpl)affiliationButtonUIImpl.getView()), employeeListUIImpl, affiliationButtonUIImpl)
        {
            //super(controller,
            //    new EmployeeManagerPanel(
            //        employeeListUIImpl.getView(),
            //        affiliationButtonUIImpl.getView()
            //    ),
            //    employeeListUIImpl,
            //    affiliationButtonUIImpl
            //);
        }

    }
}
