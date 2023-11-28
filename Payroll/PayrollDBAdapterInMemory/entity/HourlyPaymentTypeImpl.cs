using PayrollEntities;
using PayrollEntities.paymenttype;

namespace PayrollDBAdapterInMemory.entity
{
    public class HourlyPaymentTypeImpl : HourlyPaymentType
    {
        private int _hourlyWage;
        private Dictionary<DateTime, TimeCard> _timeCardsByDate = new Dictionary<DateTime, TimeCard>();

        public HourlyPaymentTypeImpl(int hourlyWage)
        {
            _hourlyWage = hourlyWage;
        }

        public int HourlyWage
        {
            get => _hourlyWage;
            set => _hourlyWage = value;
        }

        public void AddTimeCard(TimeCard timeCard)
        {
            _timeCardsByDate[timeCard.getDate()] = timeCard;
        }

        public override IEnumerable<TimeCard> getTimeCardsIn(PayrollEntities.DateInterval dateInterval)
        {
            return _timeCardsByDate
                .Where(entry => dateInterval.isBetweenInclusive(entry.Key))
                .Select(entry => entry.Value)
                .ToList();
        }

        public TimeCard? GetTimeCard(DateTime date)
        {
            var singleDateInterval = DateInterval.ofSingleDate(date);
            return getTimeCardsIn(singleDateInterval).FirstOrDefault();
        }

        public override void setHourlyWage(int hourlyWage)
        {
            this._hourlyWage = hourlyWage;
        }

        public override int? getHourlyWage()
        {
            return _hourlyWage;
        }

        public override void addTimeCard(TimeCard timeCard)
        {
            throw new NotImplementedException();
        }

        public override TimeCard? getTimeCard(DateTime date)
        {
            throw new NotImplementedException();
        }


    }

}

