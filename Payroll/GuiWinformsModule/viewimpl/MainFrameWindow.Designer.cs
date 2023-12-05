using PayrollWinformsPrototype;

namespace PayrollGuiWinformsImpl.viewimpl
{
    partial class MainFrameWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormClosing += (sender, e) => Application.Exit();
            this.Text = GuiConstants.APP_TITLE; // Assuming GuiConstants.AppTitle is a constant for the title
            this.Size = new System.Drawing.Size(850, 500);
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;

            this.contentPane = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.centrePanel = new System.Windows.Forms.Panel();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.centrePanelTop = new System.Windows.Forms.Panel();
            this.mainPanelHolder = new System.Windows.Forms.Panel();
            this.centrePanelBottom = new System.Windows.Forms.Panel();
            this.lblTodaysPayments = new System.Windows.Forms.Label();
            this.statusBarHolder = new Panel();
            this.contentPane.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.centrePanel.SuspendLayout();
            this.centrePanelTop.SuspendLayout();
            this.centrePanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPane
            // 
            this.contentPane.ColumnCount = 1;
            this.contentPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentPane.Controls.Add(this.topPanel, 0, 0);
            this.contentPane.Controls.Add(this.centrePanel, 0, 1);
            this.contentPane.Location = new System.Drawing.Point(1, 0);
            this.contentPane.Name = "contentPane";
            this.contentPane.RowCount = 3;
            this.contentPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47382F));
            this.contentPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.52618F));
            this.contentPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.contentPane.Size = new System.Drawing.Size(798, 595);
            this.contentPane.TabIndex = 0;
            // 
            // topPanel
            //
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(792, 15);
            this.topPanel.TabIndex = 0;
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
            // 
            // centrePanel
            // 
            this.centrePanel.Controls.Add(this.centrePanelBottom);
            this.centrePanel.Controls.Add(this.centrePanelTop);
            this.centrePanel.Location = new System.Drawing.Point(3, 60);
            this.centrePanel.Name = "centrePanel";
            this.centrePanel.Size = new System.Drawing.Size(792, 413);
            this.centrePanel.TabIndex = 1;
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
            // centrePanelTop
            // 
            this.centrePanelTop.Controls.Add(this.mainPanelHolder);
            this.centrePanelTop.Controls.Add(this.lblEmployees);
            this.centrePanelTop.Location = new System.Drawing.Point(3, 3);
            this.centrePanelTop.Name = "centrePanelTop";
            this.centrePanelTop.Size = new System.Drawing.Size(789, 254);
            this.centrePanelTop.TabIndex = 0;
            // 
            // employeeManagerPanelHolder
            // 
            this.mainPanelHolder.Location = new System.Drawing.Point(3, 20);
            this.mainPanelHolder.Name = "employeeManagerPanelHolder";
            this.mainPanelHolder.Size = new System.Drawing.Size(783, 231);
            this.mainPanelHolder.TabIndex = 1;
            // 
            // centrePanelBottom
            // 
            this.centrePanelBottom.Controls.Add(this.lblTodaysPayments);
            this.centrePanelBottom.Location = new System.Drawing.Point(3, 263);
            this.centrePanelBottom.Name = "centrePanelBottom";
            this.centrePanelBottom.Size = new System.Drawing.Size(786, 219);
            this.centrePanelBottom.TabIndex = 1;
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
            // statusBarHolder
            // 
            this.statusBarHolder.Location = new System.Drawing.Point(3, 550);
            this.statusBarHolder.Name = "statusBarHolder";
            this.statusBarHolder.Size = new System.Drawing.Size(789, 42);
            this.statusBarHolder.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.contentPane);
            this.Name = "MainFrameWindow";
            this.Text = GuiConstants.APP_TITLE;
            this.contentPane.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.centrePanel.ResumeLayout(false);
            this.centrePanelTop.ResumeLayout(false);
            this.centrePanelTop.PerformLayout();
            this.centrePanelBottom.ResumeLayout(false);
            this.centrePanelBottom.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel contentPane;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.Panel centrePanel;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Panel centrePanelTop;
        private System.Windows.Forms.Panel mainPanelHolder;
        private System.Windows.Forms.Panel centrePanelBottom;
        private System.Windows.Forms.Label lblTodaysPayments;
        private Panel statusBarHolder;
    }
}