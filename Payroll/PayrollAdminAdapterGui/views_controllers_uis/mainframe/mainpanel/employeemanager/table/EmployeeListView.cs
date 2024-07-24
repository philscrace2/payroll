namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table
{
    public interface EmployeeListView : ControlView<EmployeeListViewListener>, ModelConsumer<EmployeeListViewModel>
    {

    }

    public interface EmployeeListViewListener : ViewListener
    {
        void onSelectionChanged(int? employeeIndex);
    }

    public class EmployeeListViewModel
    {
        private List<EmployeeViewItem> employeeViewItems;

        public EmployeeListViewModel(List<EmployeeViewItem> employeeViewItems)
        {
            this.EmployeeViewItems = employeeViewItems;
        }

        public List<EmployeeViewItem> EmployeeViewItems { get => employeeViewItems; set => employeeViewItems = value; }
    }

}


