using PayrollAdminAdapterGui.validation;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
using PayrollEntities.paymentmethod;
using PayrollGuiWinformsImpl.viewimpl.component.field;
using PayrollGuiWinformsImpl.viewimpl.dialog.addemployee.typespecific;
using PayrollGuiWinformsImpl.viewimpl.dialog.addemployee.paymentmethod;
using static OkCancelButtonBar;
using PayrollGuiWinformsImpl.viewimpl.component.composite;
using System.ComponentModel;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.addemployee
{
    public partial class AddEmployeeDialog : DefaultModalDialog<AddEmployeeViewListener>, AddEmployeeView, IOkCancelButtonBarListener
    {
        private FieldsPanel fieldsPanel = new FieldsPanel();
        private ValidationErrorMessagesLabel errorMessageLabel;
        private Panel tableHolder;
        private AddEmployeeViewListener listener;
        private Button btFulfillPayment;
        private IntegerField ifEmployeeId = new IntegerField();
        private TextBox tfName = new TextBox();
        private TextBox tfAddress = new TextBox();

        private EmployeeFieldsPanel<SalariedEmployeeViewModel> currentEmployeeFieldsPanel;
        private PaymentMethodFieldsPanel<PaymentMethod> currentPaymentMethodFieldsPanel;

        private Dictionary<EmployeeType, EmployeeFieldsPanel<SalariedEmployeeViewModel>> employeeFieldsPanelByEmployeeType = new Dictionary<EmployeeType, EmployeeFieldsPanel<SalariedEmployeeViewModel>>();
        private Dictionary<PaymentMethodEnum, PaymentMethodFieldsPanel<PaymentMethod>> paymentMethodFieldsPanelByPaymentMethod = new Dictionary<PaymentMethodEnum, PaymentMethodFieldsPanel<PaymentMethod>>();


        //Construction
        public AddEmployeeDialog() : this(null)
        {

            //paymentMethodFieldsPanelByPaymentMethod = new Dictionary<PaymentMethodEnum, PaymentMethodFieldsPanel<object>>
            //{
            //    { PaymentMethodEnum.PAYMASTER, new PaymasterPaymentMethodFieldsPanel() as PaymentMethodFieldsPanel<object> },
            //    { PaymentMethodEnum.DIRECT_DEPOSIT, new DirectPaymentMethodFieldsPanel() as PaymentMethodFieldsPanel<object> }
            //};


        }


        public AddEmployeeDialog(string name) : base(name)
        {
            employeeFieldsPanelByEmployeeType = new Dictionary<EmployeeType, EmployeeFieldsPanel<SalariedEmployeeViewModel>>();

            employeeFieldsPanelByEmployeeType.Add(EmployeeType.SALARIED, new SalariedEmployeeFieldsPanel());

            paymentMethodFieldsPanelByPaymentMethod = new Dictionary<PaymentMethodEnum, PaymentMethodFieldsPanel<PaymentMethod>>();
            paymentMethodFieldsPanelByPaymentMethod.Add(PaymentMethodEnum.DIRECT_DEPOSIT, new PaymentMethodFieldsPanel<PaymentMethod>());
            //{
            //    { EmployeeType.SALARIED, new SalariedEmployeeFieldsPanel() as IEmployeeFieldsPanel}
            //    //{ EmployeeType.HOURLY, new HourlyEmployeeFieldsPanel() as IEmployeeFieldsPanel },
            //    //{ EmployeeType.COMMISSIONED, new CommissionedEmployeeFieldsPanel<EmployeeViewModel>() }
            //};
            //InitUI();
            InitializeComponent();
            InitCommonFields();
            PopulateComboBoxes();
            InitListeners();
            InitDefaults();
        }

        private void InitDefaults()
        {
            cbEmployeeType.SelectedIndex = 0;
            cbPaymentMethod.SelectedIndex = 0;
        }

        private void InitListeners()
        {
            cbEmployeeType.SelectedIndexChanged += (sender, e) =>
            {
                currentEmployeeFieldsPanel = employeeFieldsPanelByEmployeeType[(EmployeeType) cbEmployeeType.SelectedItem]; //.get((EmployeeType)cbEmployeeType.getSelectedItem());

                updateTypeSpecificPanelsVisibility();
            };
            cbPaymentMethod.SelectedIndexChanged += (sender, e) =>
            {
                currentPaymentMethodFieldsPanel = paymentMethodFieldsPanelByPaymentMethod[PaymentMethodEnum.DIRECT_DEPOSIT];
                // Update payment method panels visibility
                updatePaymentMethodPanelsVisibility();

            };
        }

        private void updateTypeSpecificPanelsVisibility()
        {
            foreach (var panel in employeeFieldsPanelByEmployeeType.Values)
            {
                // Assuming EmployeeFieldsPanel<object> has a 'Visible' property in C#
                //panel.Visible = (panel == currentEmployeeFieldsPanel);
            }
        }

        private void updatePaymentMethodPanelsVisibility()
        {
            foreach (var panel in paymentMethodFieldsPanelByPaymentMethod.Values)
            {
                panel.Visible = panel == currentPaymentMethodFieldsPanel;
            }

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

        public void OnCancelTrigger(object o, EventArgs e)
        {
            OnCancel();
        }

        public void OnCancel()
        {
            GetViewListener().onCancel();
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
            //viewModel.PaymentMethod = currentPaymentMethodFieldsPanel.getModel();
            return viewModel;
        }

        private void InitUI()
        {
            this.Size = new System.Drawing.Size(450, 450);
            this.Controls.Add(CreateMainPanel()); //, BorderLayout.NORTH
            this.Controls.Add(CreateOkCancelButtonBar()); //, BorderLayout.SOUTH
        }

        private Panel CreateMainPanel()
        {
            Panel mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Top;
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(CreatePanel1());
            mainPanel.Controls.Add(CreatePanel2());
            mainPanel.Controls.Add(CreateErrorMessageLabel());
            return mainPanel;
        }

        private Panel CreatePanel1()
        {
            Panel panel1 = new Panel();
            panel1.Dock = DockStyle.Top;
            panel1.AutoSize = true;
            panel1.Controls.Add(fieldsPanel);
            panel1.Controls.Add(CreateTypeSpecificFieldsPanels());
            return panel1;
        }

        private Panel CreatePanel2()
        {
            Panel panel2 = new Panel();
            panel2.Dock = DockStyle.Top;
            panel2.AutoSize = true;
            FieldsPanel fieldsPanel1 = new FieldsPanel();
            panel2.Controls.Add(fieldsPanel1);
            fieldsPanel1.AddField("Payment Method", cbPaymentMethod);
            panel2.Controls.Add(CreatePaymentMethodFieldsPanels());
            return panel2;
        }

        private Panel CreateTypeSpecificFieldsPanels()
        {
            Panel typeSpecificFieldsPanels = new Panel();
            typeSpecificFieldsPanels.Dock = DockStyle.Bottom;
            typeSpecificFieldsPanels.AutoSize = true;
            foreach (var panel in employeeFieldsPanelByEmployeeType.Values)
            {
                typeSpecificFieldsPanels.Controls.Add(panel);
            }
            return typeSpecificFieldsPanels;
        }

        private Panel CreatePaymentMethodFieldsPanels()
        {
            Panel paymentMethodFieldsPanels = new Panel();
            paymentMethodFieldsPanels.Dock = DockStyle.Bottom;
            paymentMethodFieldsPanels.AutoSize = true;
            foreach (var panel in paymentMethodFieldsPanelByPaymentMethod.Values)
            {
                //paymentMethodFieldsPanels.Controls.Add(panel);
            }
            return paymentMethodFieldsPanels;
        }

        private Label CreateErrorMessageLabel()
        {
            ValidationErrorMessagesLabel errorMessageLabel = new ValidationErrorMessagesLabel();
            errorMessageLabel.Dock = DockStyle.Top;
            errorMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            return errorMessageLabel;
        }

        private Control CreateOkCancelButtonBar()
        {
            OkCancelButtonBar okCancelButtonBar = new OkCancelButtonBar(this, "ADD", "CANCEL");
            okCancelButtonBar.Dock = DockStyle.Bottom;
            return okCancelButtonBar;
        }


        public void setModel(ValidationErrorMessagesModel viewModel)
        {

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
