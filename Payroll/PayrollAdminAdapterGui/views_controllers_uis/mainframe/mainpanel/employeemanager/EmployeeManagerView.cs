namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager
{
    public interface EmployeeManagerView : ControlView<EmployeeManagerView.EmployeeManagerViewListener>, ModelConsumer<EmployeeManagerViewModel>
    {
        public interface EmployeeManagerViewListener
        {
            void onDeleteEmployeeAction();
            void onAddEmployeeAction();
            void onAddTimeCardAction();
            void onAddSalesReceiptAction();
            void onAddServiceChargeAction();
        }
    }




    public class EmployeeManagerViewModel
    {
        public ButtonEnabledStates buttonsEnabledStates;
        public EmployeeManagerViewModel(ButtonEnabledStates buttonsEnabledStates)
        {
            this.buttonsEnabledStates = buttonsEnabledStates;
        }

        public class ButtonEnabledStates
        {
            public bool deleteEmployee;
            public bool addTimeCard;
            public bool addSalesReceipt;
            public bool addServiceCharge;
        }
    }
}