namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.common.error
{
    public abstract class ErrorDialogUI<V> : UI<V, ErrorDialogController<V>> where V : ErrorDialogView
    {
        private readonly ErrorDialogController<V> controller;

        public ErrorDialogUI(ErrorDialogController<V> controller, V view) : base(controller, view)
        {
            this.controller = controller;
        }

        public void Show(Exception e)
        {
            controller.SetThrowable(e);
            controller.Show();
        }
    }


}