

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addunionmemberaffiliation
{
    public interface IAddUnionMemberUI
    {
        void show();
    }

    public class AddUnionMemberUI<V> : UI<V, AddUnionMemberController<V>>, IAddUnionMemberUI where V : AddUnionMemberView
    {
        public AddUnionMemberUI(
                AddUnionMemberController<V>.AddUnionMemberControllerFactory controllerFactory,
                V view,
                int? employeeId) : base(controllerFactory.create(employeeId), view)
        {

        }

        public void show()
        {
            controller.showIt();
        }

        public interface AddUnionMemberUIFactory
        {
            AddUnionMemberUI<V> create(int? employeeId);
        }


    }




}

