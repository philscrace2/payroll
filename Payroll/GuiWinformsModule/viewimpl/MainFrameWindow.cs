using PayrollGuiWinformsImpl.viewimpl.mainframe;

namespace PayrollGuiWinformsImpl.viewimpl
{
    public partial class MainFrameWindow : Form
    {
        public MainFrameWindow(MainPanel mainPanel, StatusBarPanel statusBarPanel)
        {
            InitializeComponent();
            mainPanelHolder.Controls.Add(mainPanel);
            statusBarHolder.Controls.Add(statusBarPanel);
        }

        private void InitUI()
        {
            Panel contentPane = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(5)
            };
            this.Controls.Add(contentPane);

            Panel topPanel = new Panel
            {
                Dock = DockStyle.Top
            };
            contentPane.Controls.Add(topPanel);

            Panel centerPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            contentPane.Controls.Add(centerPanel);

            mainPanelHolder = new Panel
            {
                Dock = DockStyle.Fill
            };
            centerPanel.Controls.Add(mainPanelHolder);

            Panel bottomPanel = new Panel
            {
                Dock = DockStyle.Bottom
            };
            contentPane.Controls.Add(bottomPanel);

            statusBarHolder = new Panel
            {
                Dock = DockStyle.Top
            };
            bottomPanel.Controls.Add(statusBarHolder);
        }

        public void ShowIt()
        {
            //this.Invoke((MethodInvoker)(() =>
            //{
            //    this.Visible = true;
            //}));

            this.ShowDialog();
        }
    }

}
