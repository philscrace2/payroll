namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.common.error
{
    public interface ErrorDialogView : DialogView<CloseableViewListener>, ModelConsumer<ErrorViewModel>
    {


    }

    public class ErrorViewModel
    {
        public String errorMessage;

        public ErrorViewModel(String errorMessage)
        {
            this.errorMessage = errorMessage;
        }

    }


}