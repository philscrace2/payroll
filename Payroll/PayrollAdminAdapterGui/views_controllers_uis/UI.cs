namespace PayrollAdminAdapterGui.views_controllers_uis
{
    public abstract class UI
    {
        protected IController controller;
        private View view;


        public UI(IController controller, View view)
        {
            this.controller = controller;
            this.view = view;
        }



        //@Inject
        protected void init()
        {
            controller.setView(view);
        }

        public View getView()
        {
            return view;
        }
    }

    public abstract class IController
    {
        public void setView(View view)
        {

        }
    }
}