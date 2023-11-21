namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay
{
    using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist;

    public abstract class PayUI<V> : UI<V, PayController> where V : PayView
    {
        private PayListUI<PayListView> payListUI;

        public PayUI(
                PayController controller,
                V view,
                PayListUI<PayListView> payListUI
                ) : base(controller, view)
        {

            this.payListUI = payListUI;
            controller.setObservablePayListState(payListUI.getObservablePayListState());
        }

        public void setObservableCurrentDate(Observable<DateTime> observableCurrentDate)
        {
            controller.setObservableCurrentDate(observableCurrentDate);
            payListUI.setObservableCurrentDate(observableCurrentDate);
        }

    }

    // Implementation of Observable<T> and LocalDate classes/structs



}