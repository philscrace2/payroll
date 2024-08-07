using Ninject.Activation;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee
{
    public interface IAddEmployeeUI
    {
        void Show();
    }

    public abstract class AddEmployeeUI<V> : UI<V, AddEmployeeController<V>> where V : AddEmployeeView
    {
        private readonly AddEmployeeController<V> controller;

        public AddEmployeeUI(AddEmployeeController<V> controller, V view) : base(controller, view)
        {
            this.controller = controller;
            init();
        }

        public void Show()
        {
            controller.Show();
        }

    }


}