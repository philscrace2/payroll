namespace PayrollAdminAdapterGui.views_controllers_uis
{
    public interface ControlView<VL> : View
    {
        void setViewListener(VL listener);
    }

}