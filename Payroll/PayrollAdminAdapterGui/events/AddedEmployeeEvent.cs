namespace PayrollAdminAdapterGui.events
{
    public class AddedEmployeeEvent : EmployeeChangedEvent
    {

        public int? employeeId;
        public String name;

        public AddedEmployeeEvent(int? employeeId, String name)
        {
            this.employeeId = employeeId;
            this.name = name;
        }

    }


}