using System.Windows.Forms.VisualStyles;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel
{
    public partial class EmployeeManagerPanel : Panel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            employeeTablePanel = new Panel();
            employeeButtonPanel = new Panel();
            employeeManagerAddDeleteButtonPanel = new Panel();
            
            btnAddEmployee = new System.Windows.Forms.Button();         


            //this.employeeManagerMainPanel.Controls.Add(this.centrePanelContentPane, 0, 0);
            //this.contentPane.Controls.Add(this.bottomPanel, 0, 1);
            //this.contentPane.Location = new System.Drawing.Point(1, 0);
            //this.contentPane.Name = "contentPane";
            //this.contentPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));

            //this.contentPane.TabIndex = 0;
            //this.employeeManagerMainPanel.Dock = DockStyle.Fill;
            //btnDeleteEmployee = new Button();
            //btnAddTimeCard = new Button();
            //btnAddSalesReceipt = new Button();
            //btnAddServiceCharge = new Button();
            //
            // employeeManagerMainPanel
            //
            this.employeeManagerMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.employeeManagerMainPanel.ColumnCount = 2;
            this.employeeManagerMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.employeeManagerMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.employeeManagerMainPanel.Controls.Add(this.employeeTablePanel, 0, 0);
            this.employeeManagerMainPanel.Controls.Add(this.employeeButtonPanel, 0, 1);
            this.employeeManagerMainPanel.Controls.Add(this.employeeManagerAddDeleteButtonPanel, column:2, row: 0);
            this.employeeManagerAddDeleteButtonPanel.Controls.Add(btnAddEmployee);
            this.employeeManagerMainPanel.RowCount = 2;
            this.employeeManagerMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.47382F));
            this.employeeManagerMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.52618F));
            //employeeManagerMainPanel.BackColor = Color.Black;
            this.employeeManagerMainPanel.Size = new System.Drawing.Size(798, 295);

            //
            // employeeTablePanel
            //
            employeeTablePanel.BackColor = Color.Red;
            employeeTablePanel.Dock = DockStyle.Fill;           

            //
            // employeeButtonPanel
            //
            employeeButtonPanel.BackColor = Color.Chartreuse;
            employeeButtonPanel.Dock = DockStyle.Fill;

            //
            // btnAddEmployee
            //
            btnAddEmployee.Click += BtnAddEmployee_Click;
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Text = "Add...";

            //
            // EmployeeManagerPanel
            //
            this.Controls.Add(employeeManagerMainPanel);
            this.Dock = DockStyle.Fill;

        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            onAddEmployeeAction();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel employeeManagerMainPanel;
        private Panel employeeTablePanel;
        private Panel employeeButtonPanel;
        private Panel employeeManagerAddDeleteButtonPanel;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAddTimeCard;
        private System.Windows.Forms.Button btnAddSalesReceipt;
        private System.Windows.Forms.Button btnAddServiceCharge;
        private Button btnAddEmployee;     


    }
}
