using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager.affiliation;
using static PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.EmployeeManagerViewModel;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel
{
    public partial class EmployeeManagerPanel : Panel, EmployeeManagerView
    {
        private readonly EmployeeListPanel employeeListPanel;
        private readonly AffiliationButtonViewImpl affiliationButtonViewImpl;
        private EmployeeManagerView.EmployeeManagerViewListener listener;

        public EmployeeManagerPanel(EmployeeListPanel employeeListPanel, AffiliationButtonViewImpl affiliationButtonViewImpl)
        {
            InitializeComponent();
            this.employeeTablePanel.Controls.Add(employeeListPanel);
            this.affiliationButtonViewImpl = affiliationButtonViewImpl;
        }

        public void setViewListener(EmployeeManagerView.EmployeeManagerViewListener listener)
        {
            this.listener = listener;
        }

        //public void setViewListener(ViewListener getViewListener)
        //{
        //    this.listener = getViewListener;
        //}

        public void setModel(EmployeeManagerViewModel viewModel)
        {
            setButtonsEnabled(viewModel.buttonsEnabledStates);
        }

        public void onDeleteEmployeeAction()
        {
            listener.onDeleteEmployeeAction();
        }

        public void onAddEmployeeAction()
        {
            listener.onAddEmployeeAction();
        }

        public void onAddTimeCardAction()
        {
            listener.onAddTimeCardAction();
        }
        public void onAddSalesReceiptAction()
        {
            listener.onAddSalesReceiptAction();
        }

        public void onAddServiceChargeAction()
        {
            listener.onAddServiceChargeAction();
        }

        private void setButtonsEnabled(ButtonEnabledStates states)
        {
            btnDeleteEmployee.Enabled = states.deleteEmployee;
            btnAddTimeCard.Enabled = states.addTimeCard;
            btnAddSalesReceipt.Enabled = states.addSalesReceipt;
            btnAddServiceCharge.Enabled = states.addServiceCharge;
        }
    }
}
