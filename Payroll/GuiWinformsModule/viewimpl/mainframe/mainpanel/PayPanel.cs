using PayrollAdminAdapterGui.views_controllers_uis;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.pay;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel
{
    public class PayPanel : Panel, PayView
    {
        private Panel tableHolder;
        private PayViewListener listener;
        private Button btFulfillPayment;

        public PayPanel(PayListPanel payListPanel)
        {
            InitUI();
            tableHolder.Controls.Add(payListPanel);
        }

        public void SetViewListener(PayViewListener listener)
        {
            this.listener = listener;
        }

        private void InitUI()
        {
            //this.Layout = new BorderLayout(0, 0);  // BorderLayout does not exist in WinForms. You might need to use a different layout.

            tableHolder = new Panel();
            //tableHolder.Layout = new BorderLayout(0, 0);  // As above
            this.Controls.Add(tableHolder);

            Panel buttonPanel = new Panel();
            this.Controls.Add(buttonPanel);

            btFulfillPayment = new Button();
            btFulfillPayment.Text = "Fulfill Payments...";
            btFulfillPayment.Click += new EventHandler(BtFulfillPayment_Click);

            //buttonPanel.Layout = new FlowLayoutPanel();  // FlowLayoutPanel is the WinForms equivalent of FlowLayout
            buttonPanel.Controls.Add(btFulfillPayment);
        }

        private void BtFulfillPayment_Click(object sender, EventArgs e)
        {
            listener.onFulfillPayAction();
        }

        public void SetModel(PayViewModel viewModel)
        {
            btFulfillPayment.Enabled = viewModel.isFulfillButtonEnabled;
        }

        public void setViewListener(PayViewListener listener)
        {
            this.listener = listener;
        }

        public void setModel(PayViewModel viewModel)
        {
            //throw new NotImplementedException();
        }
    }
}
