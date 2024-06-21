using PayrollAdminAdapterGui.views_controllers_uis.dialog.common.confirm;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.common
{
    public class ConfirmDialogUIImpl : ConfirmDialogUI
    {
        private MainFrameUIImpl mainFrameUIImpl;
        //@Inject
        public ConfirmDialogUIImpl(MainFrameUIImpl mainFrameUIImpl)
        {
            this.mainFrameUIImpl = mainFrameUIImpl;
        }


        public void show(string message, ConfirmDialogListener confirmDialogListener)
        {
            new ConfirmDialog(mainFrameUIImpl.view, message, confirmDialogListener).showIt();
        }


        public void show(string message,
            PayrollAdminAdapterGui.views_controllers_uis.dialog.common.confirm.ConfirmDialogListener
                confirmDialogListener)
        {
            throw new NotImplementedException();
        }
    }
}
