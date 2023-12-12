using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
using PayrollGuiWinformsImpl.viewimpl.dialog;

namespace WindowsFormsApp1
{
    public partial class AddEmployeeDialog : Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cbEmployeeType = new System.Windows.Forms.ComboBox();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.LinkLabel();
            this.lblAddress = new System.Windows.Forms.LinkLabel();
            this.lblType = new System.Windows.Forms.LinkLabel();
            this.lblSalary = new System.Windows.Forms.LinkLabel();
            this.lblPaymentMethod = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPaymentMethod);
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cbEmployeeType);
            this.panel1.Controls.Add(this.cbPaymentMethod);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 465);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.txtId.Location = new System.Drawing.Point(115, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(439, 22);
            this.txtId.TabIndex = 0;
            // 
            // textBox2
            // 
            this.txtName.Location = new System.Drawing.Point(115, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(439, 22);
            this.txtName.TabIndex = 1;
            // 
            // textBox3
            // 
            this.txtAddress.Location = new System.Drawing.Point(115, 65);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(439, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // textBox4
            // 
            this.txtSalary.Location = new System.Drawing.Point(115, 173);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(439, 22);
            this.txtSalary.TabIndex = 3;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // comboBox1
            // 
            this.cbEmployeeType.FormattingEnabled = true;
            this.cbEmployeeType.Location = new System.Drawing.Point(115, 91);
            this.cbEmployeeType.Name = "cbEmployeeType";
            this.cbEmployeeType.Size = new System.Drawing.Size(439, 24);
            this.cbEmployeeType.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Location = new System.Drawing.Point(115, 240);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(439, 24);
            this.cbPaymentMethod.TabIndex = 5;
            // 
            // button1
            // 
            this.btnAdd.Location = new System.Drawing.Point(376, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.btnCancel.Location = new System.Drawing.Point(471, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 42);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(41, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 8;
            this.lblId.TabStop = true;
            this.lblId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 9;
            this.lblName.TabStop = true;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(41, 68);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(73, 20);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.TabStop = true;
            this.lblAddress.Text = "Address";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(41, 94);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 20);
            this.lblType.TabIndex = 11;
            this.lblType.TabStop = true;
            this.lblType.Text = "Type";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(41, 173);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(58, 20);
            this.lblSalary.TabIndex = 12;
            this.lblSalary.TabStop = true;
            this.lblSalary.Text = "Salary";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(5, 244);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(108, 16);
            this.lblPaymentMethod.TabIndex = 13;
            this.lblPaymentMethod.TabStop = true;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAddEmployee";
            this.Text = "Add Employee";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.LinkLabel lblPaymentMethod;
        private System.Windows.Forms.LinkLabel lblSalary;
        private System.Windows.Forms.LinkLabel lblType;
        private System.Windows.Forms.LinkLabel lblAddress;
        private System.Windows.Forms.LinkLabel lblName;
        private System.Windows.Forms.LinkLabel lblId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.ComboBox cbEmployeeType;
    }
}