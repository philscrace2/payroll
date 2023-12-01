namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.statusbar
{
    public abstract class StatusBarView : View, IStatusBarView //, PayrollAdminAdapterGui.views_controllers_uis.ModelConsumer<StatusBarViewModel>
    {
        public void setViewListener(ViewListener getViewListener)
        {
            throw new NotImplementedException();
        }

        public void SetModel(StatusBarViewModel statusBarViewModel)
        {
            throw new NotImplementedException();
        }
    }

    public interface IStatusBarView : View
    {
        void SetModel(StatusBarViewModel model);
    }

    public class StatusBarViewModel
    {
        public String message;
        public MessageType messageType;

        public StatusBarViewModel(String message, MessageType messageType)
        {
            this.message = message;
            this.messageType = messageType;
        }


    }

    public enum MessageType
    {
        INFO,
        CONFIRM,
        ERROR
    }



}