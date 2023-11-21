namespace PayrollAdminAdapterGui.views_controllers_uis
{
    public abstract class AbstractController<V, VL> : Controller<V>
    where V : ControlView<VL>
    {
        private V view;

        public void setView(V view)
        {
            this.view = view;
            view.setViewListener(GetViewListener());
        }

        protected V GetView()
        {
            return view;
        }

        protected abstract VL GetViewListener();
    }
}
