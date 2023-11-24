namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist
{
    public abstract class PayListUI : UI
    {
        private readonly PayListController controller;

        public PayListUI(
                PayListController controller,
                PayListView view
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