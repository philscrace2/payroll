using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel
{
    public class PayUIImpl<V> : PayUI<V> where V : PayView
    {
        public PayUIImpl(PayController<V> controller, V view, PayListUI<PayListView> payListUI) : base(controller, view, payListUI)
        {
        }
    }
}
