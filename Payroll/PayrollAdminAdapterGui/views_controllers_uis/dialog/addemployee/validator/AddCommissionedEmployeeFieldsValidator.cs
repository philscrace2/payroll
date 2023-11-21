using PayrollAdminAdapterGui.validation.field;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.validator
{
    public class AddCommissionedEmployeeFieldsValidator : AddEmployeeFieldsValidator<CommissionedEmployeeViewModel>
    {
        protected override void AddSubTypeErrors(CommissionedEmployeeViewModel model)
        {
            if (model.biWeeklyBaseSalary == null)
                AddFieldValidatorError("biWeeklyBaseSalary", FieldValidatorErrorType.REQUIRED);
            if (model.commissionRatePercentage == null)
                AddFieldValidatorError("commissionRatePercentage", FieldValidatorErrorType.REQUIRED);
        }

    }

}