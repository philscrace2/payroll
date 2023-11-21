namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.statusbar
{
    public interface StatusBarView : View, PayrollAdminAdapterGui.views_controllers_uis.ModelConsumer<StatusBarViewModel>
    {



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