namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.common.confirm
{
    /** This does not have a controller */
    public interface ConfirmDialogUI
    {
        void show(String message, ConfirmDialogListener confirmDialogListener);
    }

    public interface ConfirmDialogListener
    {
        void onOk();
    }
}


