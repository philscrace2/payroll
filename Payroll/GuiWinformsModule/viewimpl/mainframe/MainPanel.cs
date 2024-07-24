using PayrollAdminAdapterGui;
using PayrollAdminAdapterGui.views_controllers_uis;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe
{
    using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel;
    using System;
    using System.Windows.Forms;

    public partial class MainPanel : Panel, MainPanelView
    {
        //private DateTimePicker currentDateField; // Assuming DateField is a wrapper around DateTimePicker
        private MainPanelViewListener listener;
        private string dateFormat = Constants.DATE_FORMAT; // Assuming this is a date format string

        public MainPanel(EmployeeManagerPanel employeeManagerPanel, PayPanel payPanel)
        {
            InitializeComponent();
            InitUI();
            employeeGridTableLayoutHolder.Controls.Add(employeeManagerPanel, 0, 1);
            //employeeGridTableLayoutHolder.Controls.Add(payPanel, 0, 2);
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

            dateTimePickerCurrentDate = new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = dateFormat,
                Size = new Size(100, 20),
                MinimumSize = new Size(50, 20)
            };
            dateTimePickerCurrentDate.ValueChanged += (sender, e) => OnCurrentDateChanged();
            topPanel.Controls.Add(dateTimePickerCurrentDate);

            topPanel.Controls.Add(new Label { Text = "- Current date" });

            Panel centerPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            contentPane.Controls.Add(centerPanel);

            employeeManagerPanelHolder = new TableLayoutPanel
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
            listener?.onChangedCurrentDate();
        }

        public void SetViewListener(MainPanelViewListener viewListener)
        {
            listener = viewListener;
        }

        public MainPanelViewModel GetModel()
        {
            return new MainPanelViewModel(dateTimePickerCurrentDate.Value);
        }

        public void setViewListener(MainPanelViewListener listener)
        {
            this.listener = listener;
        }

        public void setModel(MainPanelViewModel viewModel)
        {
            dateTimePickerCurrentDate.Value = viewModel.currentDate;
        }

        public PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.MainPanelViewModel getModel()
        {
            return new MainPanelViewModel(dateTimePickerCurrentDate.Value);
        }
    }

}
