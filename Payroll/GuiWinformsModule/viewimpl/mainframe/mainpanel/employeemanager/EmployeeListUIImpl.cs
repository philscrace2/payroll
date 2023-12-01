using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager
{
    public class EmployeeListUIImpl : EmployeeListUI<EmployeeListView>
    {
        public EmployeeListPanel View { get; }

        public EmployeeListUIImpl(EmployeeListController<EmployeeListView> controller, EmployeeListPanel view) : base(controller, view)
        {
            View = view;
        }
    }
}
