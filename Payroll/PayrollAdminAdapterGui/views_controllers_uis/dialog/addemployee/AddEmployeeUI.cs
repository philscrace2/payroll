namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee
{
    public abstract class AddEmployeeUI<V> : UI<V, AddEmployeeController> where V : AddEmployeeView
    {
        public AddEmployeeUI(AddEmployeeController controller, V view) : base(controller, view)
        {

        }

        public void show()
        {
            controller.Show();
        }

    }


}