using PayrollAdminAdapterGui.formatters.controller.msg;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.common.confirm;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist;
using PayrollPorts.primaryAdminUseCase.factories;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay
{
    public class PayController : AbstractController, PayViewListener, ChangeListener<PayListState>
    {
        private PaymentFulfillUseCaseFactory paymentFulfillUseCaseFactory;
        private Observable<DateTime> observableCurrentDate;
        private Observable<PayListState> observablePayListState;
        private ConfirmDialogUI confirmDialogUIProvider;
        private ConfirmMessageFormatter confirmMessageFormatter;
        private EventBus eventBus;

        //@Inject
        public PayController(
            PaymentFulfillUseCaseFactory paymentFulfillUseCaseFactory,
            ConfirmDialogUI confirmDialogUIProvider,
            ConfirmMessageFormatter confirmMessageFormatter,
            EventBus eventBus
            )
        {
            this.paymentFulfillUseCaseFactory = paymentFulfillUseCaseFactory;
            this.confirmDialogUIProvider = confirmDialogUIProvider;
            this.confirmMessageFormatter = confirmMessageFormatter;
            this.eventBus = eventBus;
        }

        public void setObservableCurrentDate(Observable<DateTime> observableCurrentDate)
        {
            this.observableCurrentDate = observableCurrentDate;
        }

        public void setObservablePayListState(Observable<PayListState> observablePayListState)
        {
            this.observablePayListState = observablePayListState;
            observablePayListState.addChangeListener(this);
        }


        public void onFulfillPayAction()
        {
            //var confirmDialog = confirmDialogUIProvider.Get();
            //confirmDialog.Show(
            //    confirmMessageFormatter.FulfillPayments(observablePayListState.Value.ItemCount),
            //    new ConfirmDialogListener(
            //        () =>
            //        {
            //            var response = paymentFulfillUseCaseFactory.PaymentFulfillUseCase().Execute(
            //                new PaymentFulfillRequest(observableCurrentDate.Value));
            //            eventBus.Post(new PaymentsFulfilledEvent(
            //                observableCurrentDate.Value, response.PayCheckCount, response.TotalNetAmount));
            //        }
            //    ));
        }

        public void onChanged(PayListState payListState)
        {
            PayView pv = (PayView)this.GetView();
            pv.setModel(present(observablePayListState.get()));
        }

        private PayViewModel present(PayListState payListState)
        {
            return new PayViewModel()
            {
                isFulfillButtonEnabled = !payListState.isEmpty
            };
        }

        protected override ViewListener GetViewListener()
        {
            return (PayViewListener)this;
        }
    }

}