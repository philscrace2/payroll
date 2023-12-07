namespace PayrollGuiWinformsImpl.viewimpl.mainframe
{
    public partial class MainPanel{
    
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
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.mainPaneTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();

            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.centrePanelTop = new System.Windows.Forms.Panel();
            this.centrePanelBottom = new System.Windows.Forms.Panel();
            this.lblTodaysPayments = new System.Windows.Forms.Label();
            this.employeeManagerPanelHolder = new System.Windows.Forms.Panel();
            this.payDayPanelHolder = new  System.Windows.Forms.Panel();
            this.dateTimePanelHolder = new System.Windows.Forms.Panel();
            this.centrePanelTop.SuspendLayout();
            this.centrePanelBottom.SuspendLayout();

            this.centrePanelTop.ResumeLayout(false);
            this.centrePanelTop.PerformLayout();
            this.centrePanelBottom.ResumeLayout(false);
            this.centrePanelBottom.PerformLayout();

            //
            // mainPaneTableLayoutPanel
            //
            this.mainPaneTableLayoutPanel.ColumnCount = 1;
            this.mainPaneTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPaneTableLayoutPanel.Controls.Add(this.dateTimePanelHolder, 0, 0);
            this.mainPaneTableLayoutPanel.Controls.Add(this.employeeManagerPanelHolder, 0, 1);
            this.mainPaneTableLayoutPanel.Controls.Add(this.payDayPanelHolder, 0, 2);
            this.mainPaneTableLayoutPanel.Location = new System.Drawing.Point(1, 0);
            this.mainPaneTableLayoutPanel.Name = "mainPaneTableLayoutPanel";
            this.mainPaneTableLayoutPanel.RowCount = 3;
            this.mainPaneTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47382F));
            this.mainPaneTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.52618F));
            this.mainPaneTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.mainPaneTableLayoutPanel.Size = new System.Drawing.Size(798, 595);
            this.mainPaneTableLayoutPanel.TabIndex = 0;
            this.mainPaneTableLayoutPanel.Dock = DockStyle.Fill;

            //
            // this panel
            //
            this.Controls.Add(this.mainPaneTableLayoutPanel);
            //this.Controls.Add( this.centrePanelBottom);
            this.Size = new System.Drawing.Size(1000, 600);

            // 
            // dateTimePanelHolder
            // 
            this.dateTimePanelHolder.Controls.Add(this.dateTimeLabel);
            this.dateTimePanelHolder.Controls.Add(this.txtCurrentDate);
            this.dateTimePanelHolder.Location = new System.Drawing.Point(3, 3);
            this.dateTimePanelHolder.Name = "dateTimePanelHolder";
            this.dateTimePanelHolder.Size = new System.Drawing.Size(750, 51);
            this.dateTimePanelHolder.TabIndex = 1;
            this.dateTimePanelHolder.BackColor = System.Drawing.Color.White;
            this.Dock = DockStyle.Fill;

            // 
            // payDayPanelHolder
            // 
            this.payDayPanelHolder.Controls.Add(this.lblTodaysPayments);
            this.payDayPanelHolder.Location = new System.Drawing.Point(3, 263);
            this.payDayPanelHolder.Name = "payDayPanelHolder";
            this.payDayPanelHolder.Size = new System.Drawing.Size(1000, 219);
            this.payDayPanelHolder.TabIndex = 1;
            this.payDayPanelHolder.BackColor = System.Drawing.Color.White;
            this.payDayPanelHolder.Dock = DockStyle.Fill;
            // 
            // lblTodaysPayments
            // 
            this.lblTodaysPayments.AutoSize = true;
            this.lblTodaysPayments.Location = new System.Drawing.Point(4, 3);
            this.lblTodaysPayments.Name = "lblTodaysPayments";
            this.lblTodaysPayments.Size = new System.Drawing.Size(119, 16);
            this.lblTodaysPayments.TabIndex = 0;
            this.lblTodaysPayments.Text = "Today\'s payments";
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(2, 1);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(76, 16);
            this.lblEmployees.TabIndex = 0;
            this.lblEmployees.Text = "Employees";
            // 
            // employeeManagerPanelHolder
            // 
            //this.centrePanelTop.Controls.Add(this.employeeManagerPanelHolder);
            this.employeeManagerPanelHolder.Controls.Add(this.lblEmployees);
            this.employeeManagerPanelHolder.Location = new System.Drawing.Point(3, 3);
            this.employeeManagerPanelHolder.Name = "employeeManagerPanelHolder";
            this.employeeManagerPanelHolder.Size = new System.Drawing.Size(1000, 254);
            this.employeeManagerPanelHolder.TabIndex = 0;
            this.employeeManagerPanelHolder.BackColor = System.Drawing.Color.DarkCyan;
            this.employeeManagerPanelHolder.Dock = DockStyle.Fill;
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Location = new System.Drawing.Point(8, 4);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.Size = new System.Drawing.Size(144, 22);
            this.txtCurrentDate.TabIndex = 0;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(158, 7);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(85, 16);
            this.dateTimeLabel.TabIndex = 1;
            this.dateTimeLabel.Text = "-Current Date";
            


        }

        private TableLayoutPanel mainPaneTableLayoutPanel;

        private Panel employeeManagerPanelHolder;
        private Panel payDayPanelHolder;
        private Panel dateTimePanelHolder;

        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Panel centrePanelTop;
        private System.Windows.Forms.Panel centrePanelBottom;
        private System.Windows.Forms.Label lblTodaysPayments;
        
        
        #endregion
    }
}
