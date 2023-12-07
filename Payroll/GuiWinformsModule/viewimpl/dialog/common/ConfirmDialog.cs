using PayrollAdminAdapterGui.views_controllers_uis.dialog;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.common
{
    using System.Drawing;
    using System.Windows.Forms;

    public class ConfirmDialog : DefaultModalDialog<CloseableViewListener>, OkCancelButtonBar.IOkCancelButtonBarListener
    {
        private Label lbMessage;
        private ConfirmDialogListener confirmDialogListener;
        private string okLabelString;
        private string cancelLabelString;

        public ConfirmDialog(
            Form parentFrame,
            string message,
            ConfirmDialogListener confirmDialogListener,
            string okLabelString = "Confirm",
            string cancelLabelString = "Cancel"
        ) : base("confirm dialog string")
        {
            this.confirmDialogListener = confirmDialogListener;
            this.okLabelString = okLabelString;
            this.cancelLabelString = cancelLabelString;
            InitUI();
            SetMessage(message);
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(300, 200);
        }

        private void SetMessage(string message)
        {
            lbMessage.Text = ToCenteredHtml(message);
        }

        private string ToCenteredHtml(string message)
        {
            // HTML formatting is not supported in the same way in WinForms labels.
            // You might want to consider different ways of centering text if needed.
            return message;
        }

        public void OnOk()
        {
            confirmDialogListener.OnOk();
            Close();
        }

        public void OnCancel()
        {
            Close();
        }

        public void onCloseAction()
        {
            Close();
        }

        private void InitUI()
        {
            lbMessage = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(lbMessage);

            var okCancelButtonBar = new OkCancelButtonBar(this, okLabelString, cancelLabelString);
            Controls.Add(okCancelButtonBar);
        }
    }

    public interface ConfirmDialogListener
    {
        void OnOk();
    }


}
