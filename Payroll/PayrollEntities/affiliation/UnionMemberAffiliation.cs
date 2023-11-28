namespace PayrollEntities.affiliation
{
    public abstract class UnionMemberAffiliation : Affiliation
    {
        public abstract int? getUnionMemberId();
        public abstract int? getWeeklyDueAmount();

        public abstract void addServiceCharge(ServiceCharge serviceCharge);
        public abstract IEnumerable<ServiceCharge> getServiceChargesIn(DateInterval dateInterval);
        public int? calculateDeductionsAmount(DateInterval payInterval)
        {
            return calculateWeeklyDuesAmount(payInterval) + calculateServiceChargesAmount(payInterval);
        }

        private int? calculateWeeklyDuesAmount(DateInterval payInterval)
        {
            return countFridaysInInterval(payInterval) * getWeeklyDueAmount();
        }

        private int calculateServiceChargesAmount(DateInterval dateInterval)
        {
            return getServiceChargesIn(dateInterval)
                    .Sum(serviceCharge => serviceCharge.getAmount());

        }

        private int countFridaysInInterval(DateInterval dateInterval)
        {
            return dateInterval.CountWeekDayInclusive(DayOfWeek.Friday);
        }

    }







}

