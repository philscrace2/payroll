namespace PayrollEntities.paymenttype
{
    public abstract class HourlyPaymentType : PaymentType
    {

        public static readonly int? DAILY_NORMAL_HOURS = Constants.HOURLY_PAYMENTTYPE_DAILY_NORMAL_HOURS;
        public static readonly double OVERTIME_WAGE_MULTIPLIER = Constants.HOURLY_PAYMENTTYPE_OVERTIME_WAGE_MULTIPLIER;

        public abstract void setHourlyWage(int? hourlyWage);
        public abstract int? getHourlyWage();

        public abstract void addTimeCard(TimeCard timeCard);
        public abstract TimeCard? getTimeCard(DateTime date);
        public abstract IEnumerable<TimeCard> getTimeCardsIn(DateInterval payInterval);

        public override T accept<T>(PaymentTypeVisitor<T> visitor)
        {
            return visitor.visit(this);
        }

        public override int? calculateAmount(DateInterval payInterval)
        {
            return getTimeCardsIn(payInterval)
                .Sum(timeCard => calculateAmount(timeCard));
        }

        private int? calculateAmount(TimeCard timeCard)
        {
            SeparatedHours hours = SeparatedHours.of(timeCard.getWorkingHourQty());
            return calculateNormalTimeAmount(hours.normalHours) + calculateOvertimeAmount(hours.overTimeHours);
        }

        private int? calculateNormalTimeAmount(int? normalHours)
        {
            return normalHours * getHourlyWage();
        }

        private int? calculateOvertimeAmount(int? overTimeHours)
        {
            return (int?)(overTimeHours * (getHourlyWage() * OVERTIME_WAGE_MULTIPLIER));
        }
        //TODO: Overengineered!
        public class SeparatedHours
        {
            public readonly int? normalHours;
            public readonly int? overTimeHours;
            public SeparatedHours(int? normalHours, int? overTimeHours)
            {
                this.normalHours = normalHours;
                this.overTimeHours = overTimeHours;
            }
            public static SeparatedHours of(int? workingHourQty)
            {
                if (workingHourQty <= DAILY_NORMAL_HOURS)
                {
                    return new SeparatedHours(workingHourQty, 0);
                }
                else
                {
                    return new SeparatedHours(DAILY_NORMAL_HOURS, workingHourQty - DAILY_NORMAL_HOURS);
                }
            }
        }

    }







}


