namespace PayrollAdminAdapterGui.views_controllers_uis
{
    public abstract class AbstractController : IController, ViewListener

    {
        private View view;

        protected void setView(View view)
        {
            this.view = view;
            view.setViewListener(GetViewListener());
        }

        protected View GetView()
        {
            return view;
        }

        protected abstract ViewListener GetViewListener();

    }
}
