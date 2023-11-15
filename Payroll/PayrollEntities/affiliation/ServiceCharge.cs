using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PayrollEntities.affiliation
{
    public interface ServiceCharge
    {

        int getAmount();
        DateTime getDate();

        void setAmount(int amount);
        void setDate(DateTime date);

        public interface ServiceChargeFactory
        {
            ServiceCharge serviceCharge(DateTime date, int amount);
        }

    }

}
