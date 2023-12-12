using PayrollAdminAdapterGui.validation;
using PayrollAdminAdapterGui.views_controllers_uis;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
using PayrollGuiWinformsImpl.viewimpl.component.field;
using static OkCancelButtonBar;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.addemployee
{
    public partial class AddEmployeeDialog : DefaultModalDialog<AddEmployeeViewListener>, AddEmployeeView, IOkCancelButtonBarListener
    {
        private Panel tableHolder;
        private IAddEmployeeViewListener listener;
        private Button btFulfillPayment;
        private IntegerField ifEmployeeId = new IntegerField();
        private TextBox tfName = new TextBox();
        private TextBox tfAddress = new TextBox();
        private ComboBox cbEmployeeType = new ComboBox();
        private ComboBox cbPaymentMethod = new ComboBox();

        //private Dictionary<EmployeeType, EmployeeFieldsPanel> employeeFieldsPanelByEmployeeType = new Dictionary<EmployeeType, EmployeeFieldsPanel>();
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
                // Update type specific panels visibility
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

        private void InitializeComponent()
        {
            // Initialize and layout components
        }

        public void SetViewListener(IAddEmployeeViewListener viewListener)
        {
            listener = viewListener;
        }

        public EmployeeViewModel GetModel()
        {
            // Fill and return model
            return new EmployeeViewModel();
        }

        public void OnOk()
        {
            GetViewListener().onAddEmployee();
        }

        public void OnCancel()
        {
            listener.OnCancel();
        }

        public void setViewListener(AddEmployeeViewListener listener)
        {
            throw new NotImplementedException();
        }

        public void setViewListener(ViewListener getViewListener)
        {
            throw new NotImplementedException();
        }

        public void showIt()
        {
            throw new NotImplementedException();
        }

        public PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.EmployeeViewModel getModel()
        {
            throw new NotImplementedException();
        }

        public void setModel(ValidationErrorMessagesModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void accept(EmployeeViewModelVisitor visitor)
        {
            throw new NotImplementedException();
        }
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

    public class EmployeeViewModel
    {
        // ViewModel properties
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
