using PayrollAdminAdapterGui;
namespace PayrollWinformsPrototype
{
    public class MainPanel : Panel
    {
        private Panel employeeManagerPanelHolder = null;
        private Panel payDayPanelHolder;
        private string dateFormat = Constants.DATE_FORMAT;
        private DateTimePicker currentDateField;

        public MainPanel(EmployeeManagerPanel employeeManagerPanel, PayPanel payPanel)
        {
            InitializeComponent();
            InitUI();
            employeeManagerPanelHolder.Controls.Add(employeeManagerPanel);
            payDayPanelHolder.Controls.Add(payPanel);
        }

        private void InitializeComponent()
        {
            this.employeeManagerPanelHolder = new System.Windows.Forms.Panel();
            this.employeeManagerPanelHolder.BackColor = Color.Red;
            this.Controls.Add(this.employeeManagerPanelHolder);

            this.payDayPanelHolder = new Panel();
            this.payDayPanelHolder.BackColor = Color.Blue;
            this.Controls.Add(this.payDayPanelHolder);
        }

        private void InitUI()
        {
            Panel contentPane = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                Padding = new Padding(5)
            };
            this.Controls.Add(contentPane);

            Panel topPanel = new Panel
            {
                Dock = DockStyle.Top
            };
            contentPane.Controls.Add(topPanel);

            currentDateField = new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = dateFormat,
                Size = new Size(100, 20),
                MinimumSize = new Size(50, 20)
            };
            currentDateField.ValueChanged += (sender, e) => OnCurrentDateChanged();
            topPanel.Controls.Add(currentDateField);

            topPanel.Controls.Add(new Label { Text = "- Current date" });

            Panel centerPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            contentPane.Controls.Add(centerPanel);

            employeeManagerPanelHolder = new Panel
            {
                Dock = DockStyle.Fill
            };
            centerPanel.Controls.Add(employeeManagerPanelHolder);

            payDayPanelHolder = new Panel
            {
                Dock = DockStyle.Fill
            };
            centerPanel.Controls.Add(payDayPanelHolder);
        }

        private void OnCurrentDateChanged()
        {
            //listener?.OnChangedCurrentDate();
        }

        //public void SetViewListener(IMainPanelViewListener viewListener)
        //{
        //    listener = viewListener;
        //}

        //public MainPanelViewModel GetModel()
        //{
        //    return new MainPanelViewModel(currentDateField.Value);
        //}

        //public void setViewListener(MainPanelViewListener listener)
        //{
        //    throw new NotImplementedException();
        //}

        //public void setViewListener(ViewListener getViewListener)
        //{
        //    throw new NotImplementedException();
        //}

        //public void setModel(MainPanelViewModel viewModel)
        //{
        //    currentDateField.Value = viewModel.currentDate;
        //}

        //public PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.MainPanelViewModel getModel()
        //{
        //    throw new NotImplementedException();
        //}
    }

    public interface IMainPanelViewListener
    {
        void OnChangedCurrentDate();
    }
}

