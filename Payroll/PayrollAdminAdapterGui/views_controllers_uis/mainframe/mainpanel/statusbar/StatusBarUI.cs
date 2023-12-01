namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.statusbar
{
    public abstract class StatusBarUI<V> : UI<V, StatusBarController<V>> where V : IStatusBarView
    {
        public StatusBarUI(
                StatusBarController<V> controller,
                V view
                ) : base(controller, view)
        {

        }

    }


}