namespace PayrollWinformsPrototype
{

    public partial class MainFrameWindow : Form
    {
        private Panel mainPanelHolder;
        private Panel statusBarHolder;
        private Button button1 = null;

        public MainFrameWindow()
        {
            InitializeComponent();
        }



        public MainFrameWindow(PayrollWinformsPrototype.MainPanel mainPanel, StatusBarPanel statusBarPanel)
        {
            InitializeComponent();
            InitUI();
            //mainPanelHolder.Controls.Add(mainPanel);
            //statusBarHolder.Controls.Add(statusBarPanel);
        }

        private void InitUI()
        {
            this.FormClosing += (sender, e) => Application.Exit();
            this.Text = GuiConstants.APP_TITLE; // Assuming GuiConstants.AppTitle is a constant for the title
            this.Size = new System.Drawing.Size(850, 500);
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;

            //Panel contentPane = new Panel
            //{
            //    Dock = DockStyle.Fill,
            //    Padding = new Padding(5)
            //};
            //this.Controls.Add(contentPane);

            //Panel topPanel = new Panel
            //{
            //    Dock = DockStyle.Top
            //};
            //contentPane.Controls.Add(topPanel);

            //Panel centerPanel = new Panel
            //{
            //    Dock = DockStyle.Fill
            //};
            //contentPane.Controls.Add(centerPanel);

            //mainPanelHolder = new Panel
            //{
            //    Dock = DockStyle.Fill
            //};
            //centerPanel.Controls.Add(mainPanelHolder);

            //Panel bottomPanel = new Panel
            //{
            //    Dock = DockStyle.Bottom
            //};
            //contentPane.Controls.Add(bottomPanel);

            //statusBarHolder = new Panel
            //{
            //    Dock = DockStyle.Top
            //};
            //bottomPanel.Controls.Add(statusBarHolder);
        }

        public void ShowIt()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                this.Visible = true;
            }));
        }
    }


}
