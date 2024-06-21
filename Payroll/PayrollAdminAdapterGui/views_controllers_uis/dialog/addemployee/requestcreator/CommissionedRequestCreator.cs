using PayrollPorts.primaryAdminUseCase.request.addemployee;
using System.Numerics;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.requestcreator
{
    public class CommissionedRequestCreator : RequestCreator<CommissionedEmployeeViewModel, AddCommissionedEmployeeRequest>
    {
        protected override AddCommissionedEmployeeRequest toSpecificRequest(CommissionedEmployeeViewModel model)
        {
            AddCommissionedEmployeeRequest request = new AddCommissionedEmployeeRequest();
            request.biWeeklyBaseSalary = model.biWeeklyBaseSalary;
            request.commissionRate = Convert.ToInt32(model.commissionRatePercentage / 100d);
            return request;
        }
    }


}