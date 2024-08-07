using NGuava;
using PayrollAdminAdapterGui.events;
using PayrollAdminAdapterGui.formatters.controller.msg;


namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.statusbar
{
    public class StatusBarController<V> : Controller<V> where V : IStatusBarView
    {
        private V view;
        private EventMessageFormatter messageFormatter;

        //@Inject
        public StatusBarController(
                EventBus eventBus,
                EventMessageFormatter eventMessageFormatter
            )
        {
            this.messageFormatter = eventMessageFormatter;
            eventBus.Register(this);
        }

        //@Override
        public void setView(V view)
        {
            this.view = view;
        }

        //@Subscribe
        public void on(AddedEmployeeEvent ev)
        {
            confirmMessage(messageFormatter.format(ev));
        }

        //@Subscribe
        public void on(AddedTimeCardEvent ev)
        {
            confirmMessage(messageFormatter.format(ev));
        }

        //@Subscribe
        public void on(UpdatedTimeCardEvent ev)
        {
            confirmMessage(messageFormatter.format(ev));
        }

        //@Subscribe
        public void on(DeletedEmployeeEvent ev)
        {
            infoMessage(messageFormatter.format(ev));
        }

        //@Subscribe
        public void on(PaymentsFulfilledEvent ev)
        {
            infoMessage(messageFormatter.format(ev));
        }

        //@Subscribe
        public void on(AffiliationChangedEvent ev)
        {
            confirmMessage(messageFormatter.format(ev));
        }

        //@Subscribe
        public void on(CalledNotImplementedFunctionEvent ev)
        {
            infoMessage(messageFormatter.format(ev));
        }

        private void infoMessage(String message)
        {
            view.SetModel(new StatusBarViewModel(message, MessageType.INFO));
        }

        private void confirmMessage(String message)
        {
            view.SetModel(new StatusBarViewModel(message, MessageType.CONFIRM));
        }

    }
}