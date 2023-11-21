using PayrollPorts.primaryAdminUseCase.request.addemployee;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.requestcreator
{
    public class HourlyRequestCreator : RequestCreator<HourlyEmployeeViewModel, AddHourlyEmployeeRequest>
    {

        protected override AddHourlyEmployeeRequest toSpecificRequest(HourlyEmployeeViewModel model)
        {
            AddHourlyEmployeeRequest addHourlyEmployeeRequest = new AddHourlyEmployeeRequest();
            addHourlyEmployeeRequest.hourlyWage = model.hourlyWage;
            return addHourlyEmployeeRequest;
        }
    }

}