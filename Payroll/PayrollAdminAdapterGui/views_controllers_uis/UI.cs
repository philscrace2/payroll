namespace PayrollAdminAdapterGui.views_controllers_uis
{
    public abstract class UI
    {
        protected Controller controller;
        private View view;


        public UI(Controller controller, View view)
        {
            this.controller = controller;
            this.view = view;
        }

        //@Inject
        protected void init()
        {
            controller.SetView(view);
        }

        public View getView()
        {
            return view;
        }
    }

    public abstract class Controller
    {
        private View view;

        public virtual void SetView(View view)
        {

        }

        public virtual View GetView()
        {
            return view;
        }
    }
}