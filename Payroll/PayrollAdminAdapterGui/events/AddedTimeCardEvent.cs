namespace PayrollAdminAdapterGui.events
{
    public class AddedTimeCardEvent : PersistentDataChangedEvent
    {

        public String employeeName;
        public DateTime date;
        public AddedTimeCardEvent(String employeeName, DateTime date)
        {
            this.employeeName = employeeName;
            this.date = date;
        }

    }


}