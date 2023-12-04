using PayrollAdminAdapterGui.views_controllers_uis;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.statusbar;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe
{
    public class StatusBarPanel : UserControl, IStatusBarView
    {
        private readonly Color InfoColor = Color.Black;
        private readonly Color ConfirmColor = Color.FromArgb(0, 170, 0); // Green
        private readonly Color ErrorColor = Color.Red;

        private StatusBarTextPane statusBarTextPane;

        private ViewListener listener;

        public StatusBarPanel()
        {
            InitUI();
        }

        private void InitUI()
        {
            //this.Layout = new BorderLayout();
            statusBarTextPane = new StatusBarTextPane();
            this.Controls.Add(statusBarTextPane);
        }

        public void SetModel(StatusBarViewModel model)
        {
            SetMessage(model.message, ToColor(model.messageType));
        }

        private void SetMessage(string message, Color backgroundColor)
        {
            statusBarTextPane.SetMessage(message, backgroundColor);
        }

        private Color ToColor(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.INFO:
                    return InfoColor;
                case MessageType.CONFIRM:
                    return ConfirmColor;
                case MessageType.ERROR:
                    return ErrorColor;
                default:
                    throw new ArgumentException("Invalid message type");
            }
        }


        public void setViewListener(ViewListener getViewListener)
        {
            this.listener = getViewListener;
        }
    }
}








