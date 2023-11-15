using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollEntities.affiliation
{
    public class NoAffiliation : Affiliation
    {
        public int calculateDeductionsAmount(DateInterval payInterval)
        {
            return 0;
        }
    }
        
}
