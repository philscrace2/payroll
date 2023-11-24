namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addtimecard
{
    public abstract class AddTimeCardUI : UI
    {
        public AddTimeCardUI(
                AddTimeCardController.AddTimeCardControllerFactory controllerFactory,
                AddTimeCardView view,
                int employeeId
                ) : base(controllerFactory.create(employeeId), view)
        {

        }

        public void show()
        {
            //controller.
        }

    }

    public interface AddTimeCardUIFactory
    {
        PayrollAdminAdapterGui.views_controllers_uis.dialog.addtimecard.AddTimeCardUI Create(int employeeId);
    }
}