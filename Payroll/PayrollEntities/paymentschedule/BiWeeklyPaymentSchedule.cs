using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PayrollEntities.paymentschedule
{
    public abstract class BiWeeklyPaymentSchedule : PaymentSchedule
    {

    public static readonly DateTime PAYDAY_REFERENCE_DATE = Constants.BIWEEKLY_PAYMENT_SCHEDULE_REFERENCE_FRIDAY;
        private static readonly DayOfWeek PAYDAY_DAY_OF_WEEK = PAYDAY_REFERENCE_DATE.DayOfWeek;

    public override bool isPayDate(DateTime date)
    {
        return Util.isDayOfWeek(date, PAYDAY_DAY_OF_WEEK) && Util.isOnEvenWeekBasedOnReferenceDate(date);
    }
    protected override DateInterval getPayIntervalForValidatedPayDate(DateTime intervalEndDate)
    {
		return DateInterval.of(Util.GetIntervalStartDate(intervalEndDate), intervalEndDate);
    }


    public DateTime GetSameOrNextPayDate(DateTime referenceDate)
    {
        DateTime sameOrNextDayOfWeek = Util.GetSameOrNextDayOfWeek(referenceDate, PAYDAY_DAY_OF_WEEK);
            if (Util.isOnEvenWeekBasedOnReferenceDate(sameOrNextDayOfWeek))
                return sameOrNextDayOfWeek;
            else
                return Util.PlusWeek(sameOrNextDayOfWeek);
    }

    public static class Util
    {
        private static readonly int? NR_OF_WEEKDAYS = 7;
        private static readonly int? TWO_WEEK_DAYS_NR = NR_OF_WEEKDAYS * 2;

        public static DateTime GetIntervalStartDate(DateTime intervalEndDate)
        {
            return intervalEndDate.AddDays(Convert.ToInt32(-(TWO_WEEK_DAYS_NR - 1)));
        }


        public static bool isDayOfWeek(DateTime date, DayOfWeek dayOfWeek)
        {
            return date.DayOfWeek == dayOfWeek;
        }

        public static bool isOnEvenWeekBasedOnReferenceDate(DateTime date)
        {
            return isOnEvenWeekBasedOnEpoch(date) == isOnEvenWeekBasedOnEpoch(PAYDAY_REFERENCE_DATE);
        }

        public static bool isOnEvenWeekBasedOnEpoch(DateTime date)
        {
            DateTime unixEpoch = new DateTime(1970, 1, 1);
            long epochDay = (date - unixEpoch).Days;

            long epochWeek = epochDay / 7;
            bool isEven = epochWeek % 2 == 0;
            return isEven;
        }

        public static DateTime PlusWeek(DateTime sameOrNextDayOfWeek)
        {
            return sameOrNextDayOfWeek.AddDays(Convert.ToInt32(NR_OF_WEEKDAYS));
        }


        public static DateTime GetSameOrNextDayOfWeek(DateTime referenceDate, DayOfWeek dayOfWeek)
        {
            int? daysToAdd = ((int?)dayOfWeek - (int?)referenceDate.DayOfWeek + 7) % 7;
            return referenceDate.AddDays(Convert.ToInt32(daysToAdd == 0 ? 7 : daysToAdd));
        }

        }

    }
}
