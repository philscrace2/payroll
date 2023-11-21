namespace PayrollAdminAdapterGui.events
{
    public class UpdatedTimeCardEvent : PersistentDataChangedEvent
    {

        public String employeeName;
        public DateTime date;
        public UpdatedTimeCardEvent(String employeeName, DateTime date)
        {
            this.employeeName = employeeName;
            this.date = date;
        }

    }

}