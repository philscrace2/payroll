using PayrollAdminAdapterGui.events;


namespace PayrollAdminAdapterGui.formatters.controller.msg
{
    public class EventMessageFormatter
    {
        //private SmartDateFormatter smartDateFormatter;

        //@Inject
        public EventMessageFormatter(

                )
        {
            //this.smartDateFormatter = smartDateFormatterFactory.ofCurrentDate();
        }

        public String format(AddedEmployeeEvent ev)
        {
            return String.Format("Added new employee: %s with id %s", ev.name, ev.employeeId);
        }

        public String format(DeletedEmployeeEvent ev)
        {
            return String.Format("Deleted employee:(%s) %s (this can't be undone!)", ev.employeeId, ev.name);
        }

        public String format(AddedTimeCardEvent ev)
        {
            return String.Format("Timecard of %s has been added to %s", ev.date, ev.employeeName);
        }

        public String format(UpdatedTimeCardEvent ev)
        {
            return String.Format("%s's Timecard of %s has been updated", ev.employeeName, ev.date);
        }

        public String format(PaymentsFulfilledEvent ev)
        {
            return String.Format("Payments has been fulfilled for %s employee for pay-day %s as a total net of %s.",

                ev.employeeCount, "", ev.totalNetAmount);
        }

        public String format(CalledNotImplementedFunctionEvent ev)
        {
            return String.Format("%s function not implemented yet :(", ev.functionName);
        }

        public String format(AffiliationChangedEvent ev)
        {
            return changesHasBeenSaved();
        }


        private String changesHasBeenSaved()
        {
            return String.Format("Saved");
        }

    }

}