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
            //this.topPanel = new System.Windows.Forms.Panel();
            //this.mainPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.mainPanelHolder = new System.Windows.Forms.Panel();
            this.contentPane = new System.Windows.Forms.TableLayoutPanel();
            this.centrePanelContentPane = new System.Windows.Forms.Panel();
            this.statusBarHolder = new Panel();
            this.contentPane.SuspendLayout();
            //this.topPanel.SuspendLayout();
            //this.mainPanel.SuspendLayout();
            this.statusBarHolder.SuspendLayout();
            this.mainPanelHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPane
            // 
            this.contentPane.ColumnCount = 1;
            this.contentPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            //this.contentPane.Controls.Add(this.topPanel, 0, 0);
            this.contentPane.Controls.Add(this.centrePanelContentPane, 0, 0);
            this.contentPane.Controls.Add(this.bottomPanel, 0, 1);
            this.contentPane.Location = new System.Drawing.Point(1, 0);
            this.contentPane.Name = "contentPane";
            this.contentPane.RowCount = 2;
            //this.contentPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47382F));
            this.contentPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.52618F));
            this.contentPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.contentPane.Size = new System.Drawing.Size(798, 595);
            this.contentPane.TabIndex = 0;
            this.contentPane.Dock = DockStyle.Fill;
            // 
            // centrePanelContentPane
            // 
            this.centrePanelContentPane.Controls.Add(this.mainPanelHolder);
            this.centrePanelContentPane.Location = new System.Drawing.Point(3, 60);
            this.centrePanelContentPane.Name = "centrePanelContentPane";
            this.centrePanelContentPane.Size = new System.Drawing.Size(798, 600);
            this.centrePanelContentPane.Dock = DockStyle.Fill;
            this.centrePanelContentPane.BackColor = Color.Aquamarine;
            //// 
            //// topPanel
            ////
            //this.topPanel.Location = new System.Drawing.Point(3, 3);
            //this.topPanel.Name = "topPanel";
            ////this.topPanel.Size = new System.Drawing.Size(792, 51);
            //this.topPanel.TabIndex = 0;
            //this.topPanel.BackColor = System.Drawing.Color.Red;
            //this.topPanel.Dock = DockStyle.Fill;
            // 
            // centrePanel
            // 
            //this.mainPanel.Controls.Add(this.mainPanelHolder);
            //this.mainPanel.Location = new System.Drawing.Point(3, 60);
            //this.mainPanel.Name = "centrePanel";
            //this.mainPanel.Size = new System.Drawing.Size(792, 484);
            //this.mainPanel.TabIndex = 1;
            //this.mainPanel.BackColor = System.Drawing.Color.Aqua;
            //this.mainPanel.Dock = DockStyle.Fill;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.statusBarHolder);
            this.bottomPanel.Location = new System.Drawing.Point(3, 550);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(792, 42);
            this.bottomPanel.TabIndex = 2;
            this.bottomPanel.BackColor = System.Drawing.Color.Blue;
            this.bottomPanel.Dock = DockStyle.Fill;

            // 
            // mainPanelholder
            // 
            this.mainPanelHolder.Location = new System.Drawing.Point(3, 3);
            this.mainPanelHolder.Name = "mainPanelholder";
            this.mainPanelHolder.Size = new System.Drawing.Size(783, 1000);
            this.mainPanelHolder.TabIndex = 1;
            this.mainPanelHolder.BackColor = System.Drawing.Color.Orange;
            this.mainPanelHolder.Dock = DockStyle.Fill;
            //this.mainPanelHolder.Controls.Add(this.centrePanelContentPane);
            // 
            // statusBarHolder
            // 
            this.statusBarHolder.Location = new System.Drawing.Point(3, 0);
            this.statusBarHolder.Name = "statusBarHolder";
            this.statusBarHolder.Size = new System.Drawing.Size(789, 42);
            this.statusBarHolder.TabIndex = 2;
            this.statusBarHolder.BackColor = Color.Green;
            this.statusBarHolder.Dock = DockStyle.Fill;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1000);
            this.Size = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.contentPane);
            this.Name = "MainFrameWindow";
            this.Text = GuiConstants.APP_TITLE;
            this.contentPane.ResumeLayout(false);
            //this.topPanel.ResumeLayout(false);
            //this.centrePanel.ResumeLayout(false);
            this.statusBarHolder.ResumeLayout(false);
            this.mainPanelHolder.ResumeLayout(false);
            //this.topPanel.PerformLayout();
            //this.centrePanel.PerformLayout();
            this.statusBarHolder.PerformLayout();
            this.mainPanelHolder.PerformLayout();
            this.ResumeLayout(false);

            this.FormClosing += (sender, e) => Application.Exit();
            this.Text = GuiConstants.APP_TITLE; // Assuming GuiConstants.AppTitle is a constant for the title
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;



        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel contentPane;
        private System.Windows.Forms.Panel centrePanelContentPane;
        //private System.Windows.Forms.Panel topPanel;
        //private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel mainPanelHolder;
        private System.Windows.Forms.Panel statusBarHolder;
    }
}