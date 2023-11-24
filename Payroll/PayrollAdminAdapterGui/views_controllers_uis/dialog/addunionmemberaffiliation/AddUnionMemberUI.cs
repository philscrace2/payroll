

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addunionmemberaffiliation
{
    public class AddUnionMemberUI<V, C> : UI<V, C> where V : AddUnionMemberView where C : AddUnionMemberController<V>
    {
        public AddUnionMemberUI(
                C controllerFactory,
                V view,
                int employeeId
                ) : base(controllerFactory.Create(employeeId), view)
        {

        }

        public void show()
        {
            controller.Show();
        }


    }
    public interface AddUnionMemberUIFactory
    {
        AddUnionMemberUI<AddUnionMemberView, AddUnionMemberController> create(int employeeId);
    }



}

