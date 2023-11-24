namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee
{
    //public abstract class AddEmployeeUI<V, C> : UI<V, C> where V : AddEmployeeView where C : AddEmployeeController<V>
    //{
    //    public AddEmployeeUI(C controller, V view) : base(controller, view)
    //    {

    //    }

    //    public void show()
    //    {
    //        controller.Show();
    //    }

    //}

    public abstract class AddEmployeeUI<V> : UI
    {
        public AddEmployeeUI(AddEmployeeController<V> controller, V view) : base(controller, view)
        {
        }

        public void Show()
        {
            controller.Show();
        }
    }


}