using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.addemployee.typespecific
{
    public abstract class EmployeeFieldsPanel<T> : FieldsPanel where T : EmployeeViewModel
    {
        public EmployeeFieldsPanel()
        {

        }

        public abstract T getModel();
    }
}
