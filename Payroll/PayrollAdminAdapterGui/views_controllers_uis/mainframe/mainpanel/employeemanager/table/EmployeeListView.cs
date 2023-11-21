namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table
{
    public interface EmployeeListView : ControlView<EmployeeListViewListener>, ModelConsumer<EmployeeListViewModel>
    {

    }

    public interface EmployeeListViewListener
    {
        void onSelectionChanged(int? employeeIndex);
    }

    public class EmployeeListViewModel
    {
        public List<EmployeeViewItem> employeeViewItems;

        public EmployeeListViewModel(List<EmployeeViewItem> employeeViewItems)
        {
            this.employeeViewItems = employeeViewItems;
        }

    }

}


