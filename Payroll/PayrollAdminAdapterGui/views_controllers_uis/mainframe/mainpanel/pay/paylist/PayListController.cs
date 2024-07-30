using NGuava;
using PayrollAdminAdapterGui.events;
using PayrollAdminAdapterGui.formatters.usecase.response;
using PayrollPorts.primaryAdminUseCase.factories;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist
{
    public class PayListController<V> : Controller<V>, ChangeListener<DateTime> where V : PayListView
    {

        private PayListUseCaseFactory payListUseCaseFactory;
        private PayListView view;
        private PayListPresenter payListPresenter;
        private Observable<DateTime> observableCurrentDate;
        private ObservableValue<PayListState> observablePayListState = new ObservableValue<PayListState>(new PayListState(0, true));

        //@Inject
        public PayListController(
                PayListUseCaseFactory payListUseCaseFactory,
                PayListPresenter listPresenter,
                EventBus eventBus
                )
        {
            this.payListUseCaseFactory = payListUseCaseFactory;
            payListPresenter = listPresenter;
            eventBus.Register(this);
        }

        public void setView(V view)
        {
            this.view = view;
        }

        public void setObservableCurrentDate(Observable<DateTime> observableCurrentDate)
        {
            this.observableCurrentDate = observableCurrentDate;
            observableCurrentDate.addChangeListener(this);
        }

        public Observable<PayListState> getObservablePayListState()
        {
            return observablePayListState;
        }

        //@Subscribe
        public void on(PersistentDataChangedEvent e)
        {
            update();
        }

        //@Override
        public void onChanged(DateTime currentDate)
        {
            update();
        }

        private void update()
        {
            update(getPayListResponse());
        }

        private PayListResponse getPayListResponse()
        {
            return payListUseCaseFactory.payListUseCase().Execute(new PayListRequest(observableCurrentDate.get()));
        }

        private void update(PayListResponse payListResponse)
        {
            view.setModel(payListPresenter.ToViewModel(payListResponse));
            observablePayListState.set(new PayListState(
                    payListResponse.payListResponseItems.Count,
                    payListResponse.payListResponseItems.Count == 0
                    ));
        }

        public class PayListPresenter
        {
            private PaymentTypeResponseToStringFormatter paymentTypeResponseToStringFormatter;
            private PaymentMethodTypeResponseToStringFormatter paymentMethodTypeResponseToStringFormatter;

            //@Inject
            public PayListPresenter(
                    PaymentTypeResponseToStringFormatter paymentTypeResponseToStringFormatter,
                    PaymentMethodTypeResponseToStringFormatter paymentMethodTypeResponseToStringFormatter
                    )
            {
                this.paymentTypeResponseToStringFormatter = paymentTypeResponseToStringFormatter;
                this.paymentMethodTypeResponseToStringFormatter = paymentMethodTypeResponseToStringFormatter;
            }

            public PayListViewModel ToViewModel(PayListResponse payListResponse)
            {
                return new PayListViewModel(ToViewModel(payListResponse.payListResponseItems));
            }


            private List<PayListViewItem> ToViewModel(List<PayListResponseItem> payChecks)
            {
                return payChecks.Select(payCheck => ToViewModel(payCheck)).ToList();
            }


            private PayListViewItem ToViewModel(PayListResponseItem payListResponseItem)
            {
                PayListViewItem payListViewItem = new PayListViewItem();
                payListViewItem.id = payListResponseItem.employeeId;
                payListViewItem.waging = payListResponseItem.paymentTypeResponse.accept(paymentTypeResponseToStringFormatter);
                payListViewItem.name = payListResponseItem.name;
                payListViewItem.grossAmount = payListResponseItem.grossAmount;
                payListViewItem.deductionsAmount = payListResponseItem.deductionsAmount;
                payListViewItem.netAmount = payListResponseItem.netAmount;
                payListViewItem.paymentMethod = paymentMethodTypeResponseToStringFormatter.Format(payListResponseItem.paymentMethodTypeResponse);
                return payListViewItem;
            }

        }

        protected ViewListener GetViewListener()
        {
            throw new NotImplementedException();
        }
    }


}