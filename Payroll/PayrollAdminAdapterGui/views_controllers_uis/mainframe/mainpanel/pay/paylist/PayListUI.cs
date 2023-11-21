namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist
{
    public abstract class PayListUI<V> : UI<V, PayListController> where V : PayListView
    {
        public PayListUI(
                PayListController controller,
                V view
                ) : base(controller, view)
        {

        }

        public void setObservableCurrentDate(Observable<DateTime> observableCurrentDate)
        {
            controller.setObservableCurrentDate(observableCurrentDate);
        }

        public Observable<PayListState> getObservablePayListState()
        {
            return controller.getObservablePayListState();
        }

    }


}