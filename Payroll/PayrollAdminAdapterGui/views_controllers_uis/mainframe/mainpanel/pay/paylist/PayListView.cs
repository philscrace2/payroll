namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist
{
    public interface PayListView : View, ModelConsumer<PayListViewModel>
    {

    }

    public class PayListViewModel
    {
        public List<PayListViewItem> payListViewItems;

        public PayListViewModel(List<PayListViewItem> payListViewItems)
        {
            this.payListViewItems = payListViewItems;
        }
    }

    public class PayListViewItem
    {
        public int id;
        public String name;
        public String waging;
        public int grossAmount;
        public int deductionsAmount;
        public int netAmount;
        public String paymentMethod;
    }


}