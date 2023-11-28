namespace PayrollEntities.affiliation
{
    public interface Affiliation
    {
        public int? calculateDeductionsAmount(DateInterval payInterval);

    }

    public interface AffiliationFactory
    {
        NoAffiliation noAffiliation();
        UnionMemberAffiliation unionMemberAffiliation(int? unionMemberId, int? weeklyDueAmount);
    }

}
