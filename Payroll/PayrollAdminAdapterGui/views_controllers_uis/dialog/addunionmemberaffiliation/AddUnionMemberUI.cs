

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addunionmemberaffiliation
{
    public class AddUnionMemberUI : UI //where V : AddUnionMemberView where C : AddUnionMemberController<V>
    {
        public AddUnionMemberUI(
                AddUnionMemberControllerFactory controllerFactory,
                AddUnionMemberView view,
                int employeeId) : base(controllerFactory.create(employeeId), view)
        {

        }

        public void show()
        {
            //this.controller.
        }


    }
    public interface AddUnionMemberUIFactory
    {
        AddUnionMemberUI create(int? employeeId);
    }



}

