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

    public abstract class AddEmployeeUI : UI
    {
        private readonly AddEmployeeController controller;

        public AddEmployeeUI(AddEmployeeController controller, AddEmployeeView view) : base(controller, view)
        {
            this.controller = controller;
        }

        public void Show()
        {
            controller.Show();
        }
    }


}