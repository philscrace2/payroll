namespace PayrollAdminAdapterGui.views_controllers_uis
{
    public abstract class UI<V, C> where V : View where C : Controller<V>
    {
        protected C controller;
        private V view;


        public UI(C controller, V view)
        {
            this.controller = controller;
            this.view = view;
            init();
        }

        //@Inject
        protected void init()
        {
            controller.setView(view);
        }

        public V getView()
        {
            return view;
        }
    }

}