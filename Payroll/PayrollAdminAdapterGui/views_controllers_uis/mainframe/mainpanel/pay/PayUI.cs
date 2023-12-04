using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay
{
    public interface IPayUI
    {
        void setObservableCurrentDate(Observable<DateTime> observableCurrentDate);
    }

    public abstract class PayUI<V> : UI<V, PayController<V>>, IPayUI where V : PayView
    {
        private readonly PayController<V> controller;
        private PayListUI<PayListView> payListUI;

        public PayUI(
                PayController<V> controller,
                V view,
                PayListUI<PayListView> payListUI
                ) : base(controller, view)
        {
            this.controller = controller;
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