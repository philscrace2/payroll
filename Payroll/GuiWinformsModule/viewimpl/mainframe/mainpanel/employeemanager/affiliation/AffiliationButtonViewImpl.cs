using PayrollAdminAdapterGui.views_controllers_uis;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.affiliationbutton;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager.affiliation
{
    public class AffiliationButtonViewImpl : Button, AffiliationButtonView
    {
        private AffiliationButtonViewListener listener;

        public AffiliationButtonViewImpl()
        {
            initUI();
        }

        private void initUI()
        {
            this.Text = "";
            this.Size = new System.Drawing.Size(190, 50);
            this.Click += AffiliationButtonViewImpl_Click;

        }

        private void AffiliationButtonViewImpl_Click(object? sender, EventArgs e)
        {
            this.listener.onActionPerformed();
        }

        public void setViewListener(AffiliationButtonViewListener listener)
        {
            this.listener = listener;
        }

        public void setViewListener(ViewListener getViewListener)
        {
            this.listener = listener;
        }

        public void setModel(AffiliationButtonViewModel viewModel)
        {
            this.Text = viewModel.buttonText;
            this.Enabled = viewModel.enabled;

        }
    }
}
