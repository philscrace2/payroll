using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager.affiliation;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe
{
    public class MainPanelUIImpl : MainPanelUI<MainPanel>
    {
        public MainPanelUIImpl(
            MainPanelController controller,
            EmployeeManagerUIImpl employeeManagerUIImpl,
            PayUIImpl payUIImpl
        ) : base(controller, new MainPanel(new EmployeeManagerPanel(new EmployeeListPanel(), new AffiliationButtonViewImpl()), new PayPanel()), employeeManagerUIImpl, payUIImpl)
        {
            //super(controller, new MainPanel(employeeManagerUIImpl.getView(), payUIImpl.getView()), employeeManagerUIImpl, payUIImpl);
        }
    }
}
