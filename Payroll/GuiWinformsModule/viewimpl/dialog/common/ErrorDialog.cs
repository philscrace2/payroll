using PayrollAdminAdapterGui.views_controllers_uis;
using PayrollAdminAdapterGui.views_controllers_uis.dialog;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.common.error;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.common
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class ErrorDialog : Form, ErrorDialogView
    {
        private RichTextBox textPane;

        public ErrorDialog(Form parentFrame) : base()
        {
            this.Text = "Error"; // Sets the title of the window
            InitUI();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Owner = parentFrame;
            this.Size = new Size(450, 300);
        }

        public void setModel(ErrorViewModel viewModel)
        {
            textPane.Text = viewModel.errorMessage;
            textPane.SelectionStart = 0;
            textPane.SelectionLength = 0;
        }


        private void InitUI()
        {
            //this.Layout = new BorderLayout(); // BorderLayout doesn't exist in WinForms; you might need to use a different layout

            Label lblNewLabel = new Label
            {
                Text = "Uncaught exception:",
                Dock = DockStyle.Top
            };
            this.Controls.Add(lblNewLabel);

            var scrollPane = new Panel // WinForms doesn't have JScrollPane; Panel with AutoScroll can be used instead
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            this.Controls.Add(scrollPane);

            textPane = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true
            };
            scrollPane.Controls.Add(textPane);

            var buttonPane = new Panel
            {
                Dock = DockStyle.Bottom,
                //Layout = new FlowLayout() // FlowLayout doesn't exist in WinForms; FlowLayoutPanel can be used instead
            };
            this.Controls.Add(buttonPane);

            Button closeButton = new Button
            {
                Text = "Close",
                DialogResult = DialogResult.Cancel
            };
            closeButton.Click += new EventHandler(CloseButton_Click);
            buttonPane.Controls.Add(closeButton);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Assuming getViewListener().onCloseAction() simply closes the dialog
        }

        // Implement the rest of your interface and additional functionality
        public void setViewListener(CloseableViewListener listener)
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

        public void close()
        {
            throw new NotImplementedException();
        }
    }

}
