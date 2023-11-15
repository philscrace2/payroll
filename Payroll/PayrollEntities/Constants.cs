using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollEntities
{
    public class Constants
    {

        /** when starts the bi-week (odd or even week) **/        
        public static readonly DateTime BIWEEKLY_PAYMENT_SCHEDULE_REFERENCE_FRIDAY = new DateTime(2015, 12, 11);


        public static readonly int HOURLY_PAYMENTTYPE_DAILY_NORMAL_HOURS = 8;
        public static readonly double HOURLY_PAYMENTTYPE_OVERTIME_WAGE_MULTIPLIER = 1.5d;

    }
}
