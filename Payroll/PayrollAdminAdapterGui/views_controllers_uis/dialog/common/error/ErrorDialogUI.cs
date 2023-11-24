namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.common.error
{
    public abstract class ErrorDialogUI : UI
    {
        private readonly ErrorDialogController controller;

        public ErrorDialogUI(ErrorDialogController controller, ErrorDialogView view) : base(controller, view)
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