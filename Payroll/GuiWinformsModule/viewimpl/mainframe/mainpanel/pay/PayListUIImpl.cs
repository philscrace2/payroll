using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.pay
{
    public class PayListUIImpl<V> : PayListUI<V> where V : PayListView
    {
        public PayListUIImpl(PayListController<V> controller, V view) : base(controller, view)
        {
        }
    }
}
