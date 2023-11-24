namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay
{
    using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist;

    public abstract class PayUI : UI
    {
        private readonly PayController controller;
        private PayListUI payListUI;

        public PayUI(
                PayController controller,
                PayView view,
                PayListUI payListUI
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