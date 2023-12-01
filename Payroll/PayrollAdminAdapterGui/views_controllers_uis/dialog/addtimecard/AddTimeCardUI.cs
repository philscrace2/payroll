namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addtimecard
{
    public interface IAddTimeCardUI
    {
        void show();
    }

    public abstract class AddTimeCardUI<V> : UI<V, AddTimeCardController<V>>, IAddTimeCardUI where V : AddTimeCardView
    {
        public AddTimeCardUI(
                AddTimeCardController<V>.AddTimeCardControllerFactory controllerFactory,
                V view,
                int employeeId
                ) : base(controllerFactory.create(employeeId), view)
        {

        }

        public void show()
        {
            controller.Show();
        }

        public interface AddTimeCardUIFactory
        {
            AddTimeCardUI<V> Create(int? employeeId);
        }

    }


}