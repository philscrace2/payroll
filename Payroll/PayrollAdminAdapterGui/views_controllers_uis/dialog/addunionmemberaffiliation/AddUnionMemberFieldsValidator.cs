using PayrollAdminAdapterGui.validation.field;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addunionmemberaffiliation
{
    public class AddUnionMemberFieldsValidator : AbstractFieldsValidator<AddUnionMemberViewOutputModel>
    {
        protected override void AddErrors(AddUnionMemberViewOutputModel model)
        {
            if (!model.unionMemberId.HasValue)
                AddFieldValidatorError("unionMemberId", FieldValidatorErrorType.REQUIRED);
            if (!model.weeklyDueAmount.HasValue)
                AddFieldValidatorError("weeklyDueAmount", FieldValidatorErrorType.REQUIRED);
        }

    }


}