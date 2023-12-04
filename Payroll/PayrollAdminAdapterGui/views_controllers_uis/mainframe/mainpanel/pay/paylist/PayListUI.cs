namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist
{
    public interface IPayListUI
    {
        void setObservableCurrentDate(Observable<DateTime> observableCurrentDate);
        Observable<PayListState> getObservablePayListState();
    }

    public abstract class PayListUI<V> : UI<V, PayListController<V>> where V : PayListView
    {
        private readonly PayListController<V> controller;

        public PayListUI(
                PayListController<V> controller,
                V view
                ) : base(controller, view)
        {
            this.controller = controller;
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