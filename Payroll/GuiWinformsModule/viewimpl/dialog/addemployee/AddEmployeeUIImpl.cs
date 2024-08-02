using Ninject.Activation;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.addemployee
{
    public class AddEmployeeUIImpl<V> : AddEmployeeUI<V> where V : AddEmployeeView
    {
        public AddEmployeeUIImpl(
        AddEmployeeController<V> controller
        ) : base(controller, (V)(new AddEmployeeDialog("Add Employee") as AddEmployeeView))
        {

        }

    }
}
