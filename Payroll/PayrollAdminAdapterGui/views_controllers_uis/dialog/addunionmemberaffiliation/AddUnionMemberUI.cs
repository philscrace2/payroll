using static PayrollAdminAdapterGui.views_controllers_uis.dialog.addunionmemberaffiliation.AddUnionMemberController;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addunionmemberaffiliation
{
    public class AddUnionMemberUI<V> : UI<V, AddUnionMemberController> where V : AddUnionMemberView
    {
        public AddUnionMemberUI(
                AddUnionMemberControllerFactory controllerFactory,
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
    public interface AddUnionMemberUIFactory
    {
        AddUnionMemberUI<AddUnionMemberView> create(int employeeId);
    }



}

