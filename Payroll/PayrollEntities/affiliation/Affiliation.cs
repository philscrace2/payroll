using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollEntities.affiliation
{ 
    public interface Affiliation
    {
        public int calculateDeductionsAmount(DateInterval payInterval);

    }

    public interface AffiliationFactory
    {
        NoAffiliation noAffiliation();
        UnionMemberAffiliation unionMemberAffiliation(int unionMemberId, int weeklyDueAmount);
    }

}
