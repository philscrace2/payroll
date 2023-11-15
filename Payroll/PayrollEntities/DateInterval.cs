using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PayrollEntities
{
    public class DateInterval
    {
        public readonly DateTime from;
	    public readonly DateTime to;

	    private DateInterval(DateTime from, DateTime to)
        {
            this.from = from;
            this.to = to;
        }

        public bool isBetweenInclusive(DateTime date)
        {
            return (date >= from && date <= to);
        }

        //NOT efficient
        public int CountWeekDayInclusive(DayOfWeek dayOfWeek)
        {
            int count = 0;
            for (DateTime date = from; date <= to; date = date.AddDays(1))
            {
                if (date.DayOfWeek == dayOfWeek)
                    count++;
            }
            return count;
        }


        public string toString()
        {
            return "DateInterval [from=" + from + ", to=" + to + "]";
        }

        public static DateInterval of(DateTime from, DateTime to)
        {
            return new DateInterval(from, to);
        }

        public static DateInterval ofSingleDate(DateTime fromAndTo)
        {
            return of(fromAndTo, fromAndTo);
        }

    }
}
