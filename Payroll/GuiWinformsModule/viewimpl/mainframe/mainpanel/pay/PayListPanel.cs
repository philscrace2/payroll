using PayrollAdminAdapterGui.views_controllers_uis;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.pay.paylist;
using System.Data;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.pay
{
    public class PayListPanel : Panel, PayListView
    {
        private DataGridView table;

        public PayListPanel()
        {
            InitUI();
        }

        private void InitUI()
        {
            //this.Layout += //new GridLayout(1, 0, 0, 0);  // GridLayout doesn't exist in WinForms; consider using a different layout

            var scrollPane = new ScrollableControl(); // WinForms doesn't have JScrollPane; ScrollableControl can be used instead
            this.Controls.Add(scrollPane);

            table = new DataGridView();
            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Similar to SINGLE_SELECTION
            scrollPane.Controls.Add(table);
        }

        public void SetModel(PayListViewModel viewModel)
        {
            table.DataSource = BuildDataTable(viewModel);
        }

        private DataTable BuildDataTable(PayListViewModel viewModel)
        {
            var dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id"),
                new DataColumn("Name"),
                new DataColumn("Waging"),
                new DataColumn("GrossAmount"),
                new DataColumn("DeductionsAmount"),
                new DataColumn("NetAmount"),
                new DataColumn("Method")
            });

            foreach (var item in viewModel.payListViewItems)
            {
                dataTable.Rows.Add(item.id, item.name, item.waging, item.grossAmount, item.deductionsAmount, item.netAmount, item.paymentMethod);
            }

            return dataTable;
        }
        public void setViewListener(ViewListener getViewListener)
        {
            throw new NotImplementedException();
        }

        public void setModel(PayListViewModel viewModel)
        {
            //throw new NotImplementedException();
        }
    }
}
