namespace PayrollEntities.affiliation
{
    public class NoAffiliation : Affiliation
    {
        public int? calculateDeductionsAmount(DateInterval payInterval)
        {
            return 0;
        }
    }

}
