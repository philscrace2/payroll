namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.statusbar
{
    public abstract class StatusBarUI<V> : UI<V, StatusBarController> where V : StatusBarView
    {
        public StatusBarUI(
                StatusBarController controller,
                V view
                ) : base(controller, view)
        {

        }

    }


}