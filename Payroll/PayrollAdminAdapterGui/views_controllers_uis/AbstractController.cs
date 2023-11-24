namespace PayrollAdminAdapterGui.views_controllers_uis
{
    public abstract class AbstractController : Controller, ViewListener
    {
        private View view;

        public override void SetView(View view)
        {
            this.view = view;
            view.setViewListener(GetViewListener());
        }

        public virtual View GetView()
        {
            return view;
        }

        protected abstract ViewListener GetViewListener();

    }
}
