namespace PayrollWinformsPrototype
{
    partial class MainFrameWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            this.mainPanelHolder = new System.Windows.Forms.Panel();
            this.mainPanelHolder.BackColor = Color.Red;
            this.mainPanelHolder.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.mainPanelHolder);

            this.statusBarHolder = new Panel();
            this.statusBarHolder.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.statusBarHolder);

            this.button1 = new System.Windows.Forms.Button();
            this.button1.BackColor = Color.Gray;
            this.button1.Text = "Add";
            this.button1.Location = new System.Drawing.Point(90, 25);
            this.button1.Size = new System.Drawing.Size(50, 25);
            this.mainPanelHolder.Controls.Add(button1);

            this.ResumeLayout(false);
        }

        #endregion
    }
}