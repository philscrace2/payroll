namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay
{
    public interface PayView : ControlView<PayViewListener>, ModelConsumer<PayViewModel>
    {

    }

    public interface PayViewListener : ViewListener
    {
        void onFulfillPayAction();
    }

    public class PayViewModel
    {
        public bool isFulfillButtonEnabled;
    }

}