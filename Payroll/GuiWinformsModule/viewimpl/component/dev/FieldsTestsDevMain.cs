namespace PayrollGuiWinformsImpl.viewimpl.component.dev
{
    public class FieldTestsDevMain : Form
    {
        private Panel contentPane;
        private DateTimePicker dateField;
        private MaskedTextBox formattedTextField;
        private Label lblFormattedtextfield;

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FieldTestsDevMain());
        }

        public FieldTestsDevMain()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Form settings
            Text = "Field Test";
            ClientSize = new Size(450, 300);
            FormClosing += (sender, args) => Application.Exit();

            // Panel setup
            contentPane = new Panel
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(contentPane);

            // DateField setup
            dateField = new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "yyyy-MM-dd"
            };
            dateField.ValueChanged += (sender, args) => OnChanged();
            contentPane.Controls.Add(dateField);

            // FormattedTextField setup
            formattedTextField = new MaskedTextBox
            {
                Mask = "0000-00-00"
            };
            contentPane.Controls.Add(formattedTextField);

            // Label setup
            lblFormattedtextfield = new Label
            {
                Text = "Formatted Text Field"
            };
            contentPane.Controls.Add(lblFormattedtextfield);

            // Buttons setup
            var setButton = new Button
            {
                Text = "Set"
            };
            setButton.Click += (sender, args) => SetValues();
            contentPane.Controls.Add(setButton);

            var getButton = new Button
            {
                Text = "Get"
            };
            getButton.Click += (sender, args) => PrintValues();
            contentPane.Controls.Add(getButton);

            // Layout (simplified for example purposes)
            contentPane.AutoSize = true;
        }

        private void OnChanged()
        {
            throw new NotImplementedException();
        }

        private void SetValues()
        {
            formattedTextField.Text = new DateTime(2016, 4, 18).ToString("yyyy-MM-dd");
            dateField.Value = new DateTime(2016, 4, 1);
        }

        private void PrintValues()
        {


        }


    }

}