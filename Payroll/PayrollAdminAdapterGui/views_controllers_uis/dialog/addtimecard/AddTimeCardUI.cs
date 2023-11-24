namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addtimecard
{
    public abstract class AddTimeCardUI<V, C> : UI<V, C> where V : AddTimeCardView where C : AddTimeCardController<V>
    {
        public AddTimeCardUI(
                C controllerFactory,
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
        PayrollAdminAdapterGui.views_controllers_uis.dialog.addtimecard.AddTimeCardUI Create(int employeeId);
    }
}