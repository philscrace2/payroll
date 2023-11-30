using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.addemployee
{
    public class AddEmployeeUIImpl : AddEmployeeUI<AddEmployeeDialog>
    {
        public AddEmployeeUIImpl(
            AddEmployeeController controller,
            MainFrameUIImpl mainFrameUIImpl
        ) : base(controller, new AddEmployeeDialog(mainFrameUIImpl))
        {

        }

    }
}
