using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PayrollEntities.paymentschedule
{
    public abstract class WeeklyPaymentSchedule : PaymentSchedule
    {

        private static readonly DayOfWeek PAYDAY_DAY_OF_WEEK = DayOfWeek.Friday;
        private static readonly int NR_OF_WEEKDAYS = 7;

        public override bool isPayDate(DateTime date)
        {
            return IsDayOfWeek(date, PAYDAY_DAY_OF_WEEK);
        }


        protected override DateInterval getPayIntervalForValidatedPayDate(DateTime intervalEndDate)
        {
            return DateInterval.of(GetIntervalStartDate(intervalEndDate), intervalEndDate);
        }

        public override DateTime getSameOrNextPayDate(DateTime referenceDate)
        {
            return GetSameOrNextDayOfWeek(referenceDate, PAYDAY_DAY_OF_WEEK);
        }

        private bool IsDayOfWeek(DateTime date, DayOfWeek dayOfWeek)
        {
            return date.DayOfWeek == dayOfWeek;
        }


        private static DateTime GetIntervalStartDate(DateTime intervalEndDate)
        {
            return intervalEndDate.AddDays(-(NR_OF_WEEKDAYS - 1));
        }


        private static DateTime GetSameOrNextDayOfWeek(DateTime referenceDate, DayOfWeek dayOfWeek)
        {
            int daysToAdd = ((int)dayOfWeek - (int)referenceDate.DayOfWeek + 7) % 7;
            if (daysToAdd == 0)
            {
                return referenceDate; // The day is the same
            }
            return referenceDate.AddDays(daysToAdd);
        }


    }
}

