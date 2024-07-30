using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager
{
    public partial class EmployeeListPanel : Panel, EmployeeListView
    {
        private EmployeeListViewListener listener;
        private EmployeeListViewModel viewModel;

        public EmployeeListPanel()
        {
            InitializeComponent();
            initEvents();
        }

        public EmployeeListPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void initEvents()
        {
            employeeDataGridView.SelectionChanged += (s, e) => { FireEmployeeSelectionChangedEvent(); };
        }

        private void FireEmployeeSelectionChangedEvent()
        {
            listener?.onSelectionChanged(GetOptionalSelectedEmployeeIndex());
        }

        public void setModel(EmployeeListViewModel viewModel)
        {
            var lastSelectedEmployee = GetOptionalSelectedEmployeeViewItem();
            this.viewModel = viewModel;

            employeeDataGridView.Rows.Clear();

            foreach (var employee in viewModel.EmployeeViewItems)
            {
                employeeDataGridView.Rows.Add(employee.id, employee.name, employee.address, employee.waging, employee.nextPayDay);
            }
            SelectEmployeeIfPossible(lastSelectedEmployee);
            FireEmployeeSelectionChangedEvent();
        }

        public void setViewListener(EmployeeListViewListener listener)
        {
            this.listener = listener;
        }
        private int? GetOptionalSelectedEmployeeIndex()
        {
            if (employeeDataGridView.SelectedRows.Count == 0)
                return null;
            return employeeDataGridView.SelectedRows[0].Index;
        }

        private EmployeeViewItem GetOptionalSelectedEmployeeViewItem()
        {
            var selectedIndex = GetOptionalSelectedEmployeeIndex();
            if (selectedIndex == null)
                return null;
            return viewModel.EmployeeViewItems[selectedIndex.Value];
        }

        private void SelectEmployeeIfPossible(EmployeeViewItem employee)
        {
            if (employee != null)
            {
                SelectEmployeeIfExists(employee.id);
            }
        }

        private void SelectEmployeeIfExists(int? employeeId)
        {
            var index = GetIndexOf(employeeId);
            if (index.HasValue)
            {
                employeeDataGridView.ClearSelection();
                employeeDataGridView.Rows[index.Value].Selected = true;
            }
        }

        private int? GetIndexOf(int? employeeId)
        {
            for (int i = 0; i < viewModel.EmployeeViewItems.Count; i++)
            {
                if (viewModel.EmployeeViewItems[i].id == employeeId)
                    return i;
            }
            return null;
        }
    }
}
