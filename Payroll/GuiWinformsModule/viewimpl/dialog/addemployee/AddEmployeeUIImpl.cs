using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.addemployee
{
    public class AddEmployeeUIImpl<V> : AddEmployeeUI<V> where V : AddEmployeeView
    {
        public AddEmployeeUIImpl(
            AddEmployeeController<V> controller,
            MainFrameUIImpl mainFrameUIImpl
        ) : base(controller, (V)(new AddEmployeeDialog(mainFrameUIImpl.mainFrameWindow) as AddEmployeeView))
        {

        }

    }
}
