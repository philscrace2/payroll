using PayrollAdminAdapterGui.validation.field;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.validator
{
    public class AddHourlyEmployeeFieldsValidator : AddEmployeeFieldsValidator<HourlyEmployeeViewModel>
    {
        protected override void AddSubTypeErrors(HourlyEmployeeViewModel model)
        {
            if (model.hourlyWage == null)
                AddFieldValidatorError("hourlyWage", FieldValidatorErrorType.REQUIRED);
        }

    }

}