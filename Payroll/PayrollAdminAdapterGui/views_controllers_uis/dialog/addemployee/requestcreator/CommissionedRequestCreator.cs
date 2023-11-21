using PayrollPorts.primaryAdminUseCase.request.addemployee;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.requestcreator
{
    public class CommissionedRequestCreator : RequestCreator<CommissionedEmployeeViewModel, AddCommissionedEmployeeRequest>
    {
        protected override AddCommissionedEmployeeRequest toSpecificRequest(CommissionedEmployeeViewModel model)
        {
            AddCommissionedEmployeeRequest request = new AddCommissionedEmployeeRequest();
            request.biWeeklyBaseSalary = model.biWeeklyBaseSalary;
            request.commissionRate = model.commissionRatePercentage / 100d;
            return request;
        }
    }


}