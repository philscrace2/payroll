using PayrollAdminAdapterGui.validation;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addunionmemberaffiliation
{
    public interface AddUnionMemberView :
    DialogView<AddUnionMemberView.AddUnionMemberViewListener>,
    ModelConsumer<AddUnionMemberViewInputModel>,
    ModelProducer<AddUnionMemberViewOutputModel>,
    ValidationErrorMessagesConsumer
    {
        public interface AddUnionMemberViewListener : CloseableViewListener, ViewListener
        {
            void onAdd();
            void onCancel();
        }

    }

    public class AddUnionMemberViewInputModel
    {
        public String employeeName;
    }

    public class AddUnionMemberViewOutputModel
    {
        public int? unionMemberId;
        public int? weeklyDueAmount;
    }
}