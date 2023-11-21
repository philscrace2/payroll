namespace PayrollAdminAdapterGui.views_controllers_uis.dialog
{
    public interface ClosableView<T> : ControlView<T>, Closeable where T : CloseableViewListener
    {

    }

}