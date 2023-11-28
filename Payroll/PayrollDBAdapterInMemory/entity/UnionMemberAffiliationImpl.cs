using PayrollEntities.affiliation;

namespace PayrollDBAdapterInMemory.entity
{
    public class UnionMemberAffiliationImpl : UnionMemberAffiliation
    {

        private int? unionMemberId;
        private int? weeklyDueAmount;

        private Dictionary<DateTime, ServiceCharge> serviceChargesByDate = new Dictionary<DateTime, ServiceCharge>();

        public UnionMemberAffiliationImpl(int? unionMemberId, int? weeklyDueAmount)
        {
            this.unionMemberId = unionMemberId;
            this.weeklyDueAmount = weeklyDueAmount;
        }

        public override int? getUnionMemberId()
        {
            return unionMemberId;
        }

        public override int? getWeeklyDueAmount()
        {
            return weeklyDueAmount;
        }

        public override void addServiceCharge(ServiceCharge serviceCharge)
        {
            serviceChargesByDate.Add(serviceCharge.getDate(), serviceCharge);
        }

        public override ICollection<ServiceCharge> getServiceChargesIn(PayrollEntities.DateInterval dateInterval)
        {
            return serviceChargesByDate
                .Where(entry => dateInterval.isBetweenInclusive(entry.Key))
                .Select(entry => entry.Value)
                .ToList();
        }


    }
}

