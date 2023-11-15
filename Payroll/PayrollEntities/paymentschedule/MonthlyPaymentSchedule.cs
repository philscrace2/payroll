using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PayrollEntities.paymentschedule
{
    public abstract class MonthlyPaymentSchedule : PaymentSchedule
    {      

    public bool IsPayDate(DateTime date)
    {
        return isLastDayOfMonth(date);
    }

    
    protected override DateInterval getPayIntervalForValidatedPayDate(DateTime payday)
    {
        return DateInterval.of(
                GetFirstDayOfMonth(payday),
                GetLastDayOfMonth(payday));
    }


    public override DateTime getSameOrNextPayDate(DateTime referenceDate)
    {
        return GetLastDayOfMonth(referenceDate);
    }

    private bool isLastDayOfMonth(DateTime date)
    {
        return GetLastDayOfMonth(date).Equals(date);
    }

    private DateTime GetFirstDayOfMonth(DateTime date)
    {
        return new DateTime(date.Year, date.Month, 1);
    }

    private DateTime GetLastDayOfMonth(DateTime date)
    {
        return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
    }

    }
}
