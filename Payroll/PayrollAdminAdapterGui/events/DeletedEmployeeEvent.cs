namespace PayrollAdminAdapterGui.events
{
    public class DeletedEmployeeEvent : EmployeeChangedEvent
    {

        public int? employeeId;
        public String name;

        public DeletedEmployeeEvent(int? employeeId, String name)
        {
            this.employeeId = employeeId;
            this.name = name;
        }

    }

}