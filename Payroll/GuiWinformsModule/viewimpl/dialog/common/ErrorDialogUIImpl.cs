using PayrollAdminAdapterGui.views_controllers_uis.dialog.common.error;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.common
{
    public class ErrorDialogUIImpl : ErrorDialogUI<ErrorDialog>
    {
        public ErrorDialogUIImpl(
            ErrorDialogController<ErrorDialog> controller,
            MainFrameUIImpl mainFrameUIImpl
        ) : base(controller, new ErrorDialog(mainFrameUIImpl.view))
        {

        }

    }
}
