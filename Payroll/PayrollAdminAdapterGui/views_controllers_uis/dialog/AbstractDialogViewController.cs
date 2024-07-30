using NGuava;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog
{
    public abstract class AbstractDialogViewController<T, VL> : AbstractController<T, VL> where T : DialogView<VL> where VL : CloseableViewListener
    {
        private EventBus eventBus; // Assuming EventBus is a class defined in your C# project

        public AbstractDialogViewController(EventBus eventBus)
        {
            this.eventBus = eventBus;
            RegisterThisToEventbus();
        }

        public AbstractDialogViewController() : this(null)
        {
        }

        private void RegisterThisToEventbus()
        {
            eventBus?.Register(this);
        }

        public void Show()
        {
            GetView().showIt();
        }

        public void onCloseAction()
        {
            if (OnCloseActionShouldCloseAutomatically())
                Close();
        }

        protected abstract bool OnCloseActionShouldCloseAutomatically();

        protected void Close()
        {
            UnregisterThisFromEventBus();
            GetView().Close(); // Assuming the Close method is defined in IDialogView
        }

        private void UnregisterThisFromEventBus()
        {
            eventBus?.UnRegister(this);
        }
    }
}