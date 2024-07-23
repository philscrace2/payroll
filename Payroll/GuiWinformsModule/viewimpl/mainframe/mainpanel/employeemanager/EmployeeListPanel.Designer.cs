namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager
{
    partial class EmployeeListPanel : Panel
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
            employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWaging = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFollowing = new System.Windows.Forms.DataGridViewTextBoxColumn();

            //
            // employeeDataGridView
            //
            employeeDataGridView.Dock = DockStyle.Fill;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.clmId,
                this.clmName,
                this.clmWaging,
                this.clmFollowing});
            this.employeeDataGridView.Location = new System.Drawing.Point(4, 3);
            this.employeeDataGridView.Name = "dataGridView1";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(775, 182);
            this.employeeDataGridView.TabIndex = 0;

            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.MinimumWidth = 6;
            this.clmId.Name = "clmId";
            this.clmId.Width = 125;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.MinimumWidth = 6;
            this.clmName.Name = "clmName";
            this.clmName.Width = 125;
            // 
            // clmName
            // 
            this.clmAddress.HeaderText = "Address";
            this.clmAddress.MinimumWidth = 6;
            this.clmAddress.Name = "clmName";
            this.clmAddress.Width = 125;
            // 
            // clmWaging
            // 
            this.clmWaging.HeaderText = "Waging";
            this.clmWaging.MinimumWidth = 6;
            this.clmWaging.Name = "clmWaging";
            this.clmWaging.Width = 125;
            // 
            // clmFollowing
            // 
            this.clmFollowing.HeaderText = "Following pay-day";
            this.clmFollowing.MinimumWidth = 6;
            this.clmFollowing.Name = "clmFollowing";
            this.clmFollowing.Width = 125;
        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWaging;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFollowing;
    }
}
