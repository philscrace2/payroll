namespace PayrollAdminAdapterGui
{
    public partial class PayrollForm : Form
    {
        private DataGridView dgvEmployees;
        private DataGridView dgvPayments;
        private Button btnAddTimeCard;
        private Button btnAddSalesReceipt;
        private Button btnFulfillPayments;

        // Other controls declarations...

        public PayrollForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Initialize and set properties for dgvEmployees
            dgvEmployees = new DataGridView();
            dgvEmployees.ColumnCount = 5;
            dgvEmployees.Columns[0].Name = "Id";
            dgvEmployees.Columns[1].Name = "Name";
            dgvEmployees.Columns[2].Name = "Address";
            dgvEmployees.Columns[3].Name = "Waging";
            dgvEmployees.Columns[4].Name = "Following pay-day";
            // Add sample data to dgvEmployees...

            // Initialize and set properties for dgvPayments
            dgvPayments = new DataGridView();
            dgvPayments.ColumnCount = 5;
            dgvPayments.Columns[0].Name = "Id";
            dgvPayments.Columns[1].Name = "Name";
            dgvPayments.Columns[2].Name = "Waging";
            dgvPayments.Columns[3].Name = "GrossAmount";
            dgvPayments.Columns[4].Name = "DeductionsAmount";
            // Add sample data to dgvPayments...

            // Initialize other controls and set their properties...
            btnAddTimeCard = new Button { Text = "Add time card...", Enabled = true };
            btnAddSalesReceipt = new Button { Text = "Add sales receipt...", Enabled = true };
            Button btnAffiliation = new Button { Text = "Affiliation...", Enabled = false };
            Button btnAddServiceCharge = new Button { Text = "Add Service charge...", Enabled = false };
            btnFulfillPayments = new Button { Text = "Fulfill Payments...", Enabled = true };
            Button btnDelete = new Button { Text = "Delete", Enabled = false };
            Button btnAdd = new Button { Text = "Add...", Enabled = false };
            // Add event handlers for buttons...

            // Layout the controls on the form
            LayoutControls();
        }

        private void LayoutControls()
        {
            // Assuming the form has a size large enough to accommodate the layout
            this.Size = new System.Drawing.Size(850, 500);

            // Layout dgvEmployees
            dgvEmployees.Location = new System.Drawing.Point(10, 40);
            dgvEmployees.Size = new System.Drawing.Size(800, 150);
            this.Controls.Add(dgvEmployees);

            // Layout dgvPayments
            dgvPayments.Location = new System.Drawing.Point(10, 250);
            dgvPayments.Size = new System.Drawing.Size(800, 100);
            this.Controls.Add(dgvPayments);

            // Layout buttons for employees section
            btnAddTimeCard.Location = new System.Drawing.Point(10, 200);
            btnAddTimeCard.Size = new System.Drawing.Size(120, 30);
            this.Controls.Add(btnAddTimeCard);

            Button btnAffiliation = new Button { Text = "Affiliation...", Enabled = false };
            btnAffiliation.Location = new System.Drawing.Point(140, 200);
            btnAffiliation.Size = new System.Drawing.Size(120, 30);
            this.Controls.Add(btnAffiliation);

            Button btnAddServiceCharge = new Button { Text = "Add Service charge...", Enabled = false };
            btnAddServiceCharge.Location = new System.Drawing.Point(270, 200);
            btnAddServiceCharge.Size = new System.Drawing.Size(150, 30);
            this.Controls.Add(btnAddServiceCharge);

            Button btnDelete = new Button { Text = "Delete", Enabled = false };
            btnDelete.Location = new System.Drawing.Point(430, 200);
            btnDelete.Size = new System.Drawing.Size(120, 30);
            this.Controls.Add(btnDelete);

            Button btnAdd = new Button { Text = "Add...", Enabled = false };
            btnAdd.Location = new System.Drawing.Point(560, 200);
            btnAdd.Size = new System.Drawing.Size(120, 30);
            this.Controls.Add(btnAdd);

            // Layout buttons for payments section
            btnAddSalesReceipt.Location = new System.Drawing.Point(10, 360);
            btnAddSalesReceipt.Size = new System.Drawing.Size(120, 30);
            this.Controls.Add(btnAddSalesReceipt);

            btnFulfillPayments.Location = new System.Drawing.Point(140, 360);
            btnFulfillPayments.Size = new System.Drawing.Size(150, 30);
            this.Controls.Add(btnFulfillPayments);

            // Continue to layout any additional controls in a similar fashion...
        }
    }
}