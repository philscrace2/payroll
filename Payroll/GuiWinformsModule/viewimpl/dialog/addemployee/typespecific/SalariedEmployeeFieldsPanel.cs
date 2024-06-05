using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.addemployee.typespecific
{
    public partial class SalariedEmployeeFieldsPanel : EmployeeFieldsPanel<SalariedEmployeeViewModel>
    {
        public SalariedEmployeeFieldsPanel()
        {
            InitializeComponent();
        }

        private void initFields()
        {
            AddField("Salary", monthlySalaryField);
        }

        public SalariedEmployeeViewModel getModel()
        {
            SalariedEmployeeViewModel salariedEmployeeViewModel = new SalariedEmployeeViewModel();
            salariedEmployeeViewModel.monthlySalary = monthlySalaryField.getInteger().orElse(null);
            return salariedEmployeeViewModel;
        }
    }
}
