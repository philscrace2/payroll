namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addtimecard
{
    public abstract class AddTimeCardUI<V> : UI<V, AddTimeCardController> where V : AddTimeCardView
    {
        public AddTimeCardUI(
                AddTimeCardControllerFactory controllerFactory,
                V view,
                int employeeId
                ) : base(controllerFactory.create(employeeId), view)
        {

        }

        public void show()
        {
            controller.Show();
        }

    }

    public interface AddTimeCardUIFactory
    {
        AddTimeCardUI Create(int employeeId);
    }




}