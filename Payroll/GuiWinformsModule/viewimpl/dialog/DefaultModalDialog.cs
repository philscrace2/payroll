using PayrollAdminAdapterGui.views_controllers_uis.dialog;
using PayrollWinformsPrototype;

namespace PayrollGuiWinformsImpl.viewimpl.dialog
{
    public class DefaultModalDialog<T> : Form, DialogView<T> where T : CloseableViewListener
    {
        private T listener;

        //public DefaultModalDialog(string name) : this(null) { }

        public DefaultModalDialog(string title)
        {
            //Owner = parentForm;
            Text = BuildTitle(title);
            //Modal = true;
            Size = new System.Drawing.Size(450, 360);

            FormClosing += (sender, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    listener.onCloseAction();
                    e.Cancel = true; // Prevents the dialog from closing
                }
            };
        }

        private string BuildTitle(string title)
        {
            return GuiConstants.APP_TITLE + (title == null ? "" : " - " + title);
        }

        public void setViewListener(T viewListener)
        {
            listener = viewListener;
        }

        protected T GetViewListener()
        {
            return listener;
        }

        private void CenterParent()
        {
            CenterToParent();
        }

        protected void close()
        {
            Dispose();
        }

        protected void SetFocus(Control component)
        {
            Shown += (sender, e) => component.Focus();
        }

        public void showIt()
        {
            ShowDialog();
        }

        private void ShowDialog()
        {
            //this.Invoke((MethodInvoker)(() =>
            //{
            //    CenterParent();
            //    this.Show();
            //}));
            base.ShowDialog();
        }

        void Closeable.close()
        {
            Dispose();
        }
    }

    //public interface ICloseableViewListener
    //{
    //    void OnCloseAction();
    //}
}
