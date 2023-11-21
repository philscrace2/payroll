using PayrollAdminAdapterGui.validation;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addtimecard
{
    public interface AddTimeCardView : DialogView<AddTimeCardViewListener>, ModelConsumer<AddTimeCardViewInputModel>, ModelProducer<AddTimeCardViewOutputModel>,
    ValidationErrorMessagesConsumer
    { }


    public interface AddTimeCardViewListener : CloseableViewListener
    {
        void onAdd();
        void onCancel();
    }

    public class AddTimeCardViewInputModel
    {
        public String employeeName;
        public DateTime defaultDate;
    }

    public class AddTimeCardViewOutputModel
    {
        public DateTime date;
        public int? workingHourQty;
    }
}