using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager
{
    public partial class EmployeeListPanel : Panel, EmployeeListView
    {
        private EmployeeListViewListener listener;
        private EmployeeListViewModel viewModel;

        public EmployeeListPanel()
        {
            InitializeComponent();
        }

        public EmployeeListPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void setModel(EmployeeListViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void setViewListener(EmployeeListViewListener listener)
        {
            this.listener = listener;
        }
    }
}
