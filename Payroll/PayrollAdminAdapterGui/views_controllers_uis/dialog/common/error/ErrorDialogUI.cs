namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.common.error
{
    public abstract class ErrorDialogUI<V, C> : UI<V, C> where V : ErrorDialogView where C : ErrorDialogController<V>
    {
        public ErrorDialogUI(C controller, V view) : base(controller, view)
        {

        }

        public void Show(Exception e)
        {
            controller.SetThrowable(e);
            controller.Show();
        }
    }


}