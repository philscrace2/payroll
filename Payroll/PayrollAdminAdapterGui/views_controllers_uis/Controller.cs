namespace PayrollAdminAdapterGui.views_controllers_uis
{
    public interface Controller<V> where V : View
    {
        public void setView(V view);
    }
}



