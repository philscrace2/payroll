namespace PayrollAdminAdapterGui.formatters.controller.msg
{
    public class ConfirmMessageFormatter
    {

        public String deleteEmployee(String employeeName)
        {
            return String.Format("You are about to delete employee %s. Are you sure?", employeeName);
        }

        public String fulfillPayments(int employeeCount)
        {
            return String.Format("Fullfill payments for the %s employee?", employeeCount);
        }

        public String timeCardAlreadyExists()
        {
            return String.Format("Timecard already exists for such date. Update?");
        }

    }


}