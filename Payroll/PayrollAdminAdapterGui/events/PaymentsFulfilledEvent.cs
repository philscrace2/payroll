namespace PayrollAdminAdapterGui.events
{
    public class PaymentsFulfilledEvent : Event
    {
        public DateTime payDate;
        public int? employeeCount;
        public int? totalNetAmount;

        public PaymentsFulfilledEvent(DateTime payDate, int? employeeCount, int? totalNetAmount)
        {
            this.payDate = payDate;
            this.employeeCount = employeeCount;
            this.totalNetAmount = totalNetAmount;
        }
    }

}