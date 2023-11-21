using PayrollAdminAdapterGui.validation.field;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addtimecard
{
    public class AddTimeCardFieldsValidator : AbstractFieldsValidator<AddTimeCardViewOutputModel>
    {
        //You changed to HasValue
        protected override void AddErrors(AddTimeCardViewOutputModel model)
        {
            if (model.date == null)
                AddFieldValidatorError("date", FieldValidatorErrorType.REQUIRED);
            if (!model.workingHourQty.HasValue)
                AddFieldValidatorError("workingHourQty", FieldValidatorErrorType.REQUIRED);
        }

    }

}