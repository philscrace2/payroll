using PayrollPorts.primaryAdminUseCase.request.addemployee;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.requestcreator
{
    public class SalariedRequestCreator : RequestCreator<SalariedEmployeeViewModel, AddSalariedEmployeeRequest>
    {
        protected override AddSalariedEmployeeRequest toSpecificRequest(SalariedEmployeeViewModel model)
        {
            AddSalariedEmployeeRequest addSalariedEmployeeRequest = new AddSalariedEmployeeRequest();
            addSalariedEmployeeRequest.monthlySalary = model.monthlySalary;
            return addSalariedEmployeeRequest;
        }
    }


}