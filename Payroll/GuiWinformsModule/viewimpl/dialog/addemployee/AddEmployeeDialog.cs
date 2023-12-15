using PayrollAdminAdapterGui.validation;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
using PayrollGuiWinformsImpl.viewimpl.component.field;
using PayrollGuiWinformsImpl.viewimpl.dialog.addemployee.typespecific;
using static OkCancelButtonBar;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.addemployee
{
    public partial class AddEmployeeDialog : DefaultModalDialog<AddEmployeeViewListener>, AddEmployeeView, IOkCancelButtonBarListener
    {
        private Panel tableHolder;
        private AddEmployeeViewListener listener;
        private Button btFulfillPayment;
        private IntegerField ifEmployeeId = new IntegerField();
        private TextBox tfName = new TextBox();
        private TextBox tfAddress = new TextBox();

        private EmployeeFieldsPanel<EmployeeViewModel> currentEmployeeFieldsPanel;

        //private Dictionary<EmployeeType, EmployeeFieldsPanel<EmployeeViewModel>> employeeFieldsPanelByEmployeeType = new Dictionary<EmployeeType, EmployeeFieldsPanel<EmployeeFieldsPanel>>();
        //private Dictionary<PaymentMethodEnum, PaymentMethodFieldsPanel> paymentMethodFieldsPanelByPaymentMethod = new Dictionary<PaymentMethodEnum, PaymentMethodFieldsPanel>();

        //public AddEmployeeDialog(Form parentForm) : this(parentForm, "")
        //{

        //}

        public AddEmployeeDialog(string title) : base("Add Employee")
        {
            InitializeComponent();
            InitCommonFields();
            PopulateComboBoxes();
            InitListeners();
            InitDefaults();
        }

        private void InitDefaults()
        {
            //cbEmployeeType.SelectedIndex = 0;
            //cbPaymentMethod.SelectedIndex = 0;
        }

        private void InitListeners()
        {
            cbEmployeeType.SelectedIndexChanged += (sender, e) =>
            {
                currentEmployeeFieldsPanel.Text = cbEmployeeType.SelectedItem.ToString();
            };
            cbPaymentMethod.SelectedIndexChanged += (sender, e) =>
            {
                // Update payment method panels visibility
            };
        }

        private void PopulateComboBoxes()
        {
            cbEmployeeType.DataSource = Enum.GetValues(typeof(EmployeeType));
            cbPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethodEnum));
        }

        private void InitCommonFields()
        {
            // Add common fields to a panel or layout
        }

        //public EmployeeViewModel GetModel()
        //{
        //    // Fill and return model
        //    return new EmployeeViewModel();
        //}

        public void OnOk()
        {
            GetViewListener().onAddEmployee();
        }

        public void OnOkTrigger(object o, EventArgs e)
        {
            OnOk();
        }

        public void OnCancel()
        {
            listener.onCancel();
        }

        public PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.EmployeeViewModel getModel()
        {
            return fillBaseModel(currentEmployeeFieldsPanel.getModel());
        }

        private PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.EmployeeViewModel fillBaseModel(EmployeeViewModel viewModel)
        {
            viewModel.EmployeeId = Convert.ToInt32(txtId.Text);
            viewModel.Name = txtName.Text;
            viewModel.Address = txtAddress.Text;
            //viewModel.PaymentMethod = cbPaymentMethod.Text;
            return viewModel;
        }

        public void setModel(ValidationErrorMessagesModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void accept(EmployeeViewModelVisitor visitor)
        {
            throw new NotImplementedException();
        }

        //public void setViewListener(AddEmployeeViewListener listener)
        //{
        //    this.listener = listener;
        //}

        //public void showIt()
        //{
        //    throw new NotImplementedException();
        //}
    }

    public interface IAddEmployeeView
    {
        void SetViewListener(IAddEmployeeViewListener listener);
        EmployeeViewModel GetModel();
    }

    public interface IAddEmployeeViewListener
    {
        void OnAddEmployee();
        void OnCancel();
    }

    public enum EmployeeType
    {
        SALARIED,
        HOURLY,
        COMMISSIONED
    }
    public enum PaymentMethodEnum
    {
        PAYMASTER,
        DIRECT_DEPOSIT
    }


}
