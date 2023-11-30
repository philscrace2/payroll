namespace PayrollAdminAdapterGui.views_controllers_uis
{
    public abstract class AbstractController<V, VL> : Controller<V>, ViewListener where V : ControlView<VL> //where VL : CloseableViewListener
    {
        private V view;

        public void setView(V view)
        {
            this.view = view;
            view.setViewListener(GetViewListener());
        }

        public V GetView()
        {
            return view;
        }

        protected abstract ViewListener GetViewListener();

    }
}
