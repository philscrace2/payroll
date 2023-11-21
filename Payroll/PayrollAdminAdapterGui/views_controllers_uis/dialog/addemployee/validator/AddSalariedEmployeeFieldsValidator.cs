using PayrollAdminAdapterGui.validation.field;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.validator
{
    public class AddSalariedEmployeeFieldsValidator : AddEmployeeFieldsValidator<SalariedEmployeeViewModel>
    {
        protected override void AddSubTypeErrors(SalariedEmployeeViewModel model)
        {
            if (model.monthlySalary == null)
                AddFieldValidatorError("monthlySalary", FieldValidatorErrorType.REQUIRED);
        }

    }


}