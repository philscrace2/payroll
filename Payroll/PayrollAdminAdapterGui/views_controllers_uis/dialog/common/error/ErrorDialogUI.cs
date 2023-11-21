namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.common.error
{
    public abstract class ErrorDialogUI<V> : UI<V, ErrorDialogController> where V : ErrorDialogView
    {
        public ErrorDialogUI(ErrorDialogController controller, V view) : base(controller, view)
        {
        }

        public void Show(Exception e)
        {
            controller.SetThrowable(e);
            controller.Show();
        }
    }


}