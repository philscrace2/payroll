using PayrollAdminAdapterGui.views_controllers_uis;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager.affiliation;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel
{
    public class EmployeeManagerPanel : Panel, EmployeeManagerView
    {
        private readonly EmployeeListPanel employeeListPanel;
        private readonly AffiliationButtonViewImpl affiliationButtonViewImpl;
        private EmployeeManagerView.EmployeeManagerViewListener listener;

        public EmployeeManagerPanel(EmployeeListPanel employeeListPanel, AffiliationButtonViewImpl affiliationButtonViewImpl)
        {
            this.employeeListPanel = employeeListPanel;
            this.affiliationButtonViewImpl = affiliationButtonViewImpl;
        }

        public void setViewListener(EmployeeManagerView.EmployeeManagerViewListener listener)
        {
            this.listener = listener;
        }

        public void setViewListener(ViewListener getViewListener)
        {
            throw new NotImplementedException();
        }

        public void setModel(EmployeeManagerViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
