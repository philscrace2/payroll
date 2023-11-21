namespace PayrollAdminAdapterGui.formatters.common
{
    public class SmartDateFormatter
    {
        private static readonly string TODAY = "Today";
        private string dateFormat = Constants.DATE_FORMAT;
        private DateTime currentDate;

        public SmartDateFormatter(DateTime currentDate)
        {
            this.currentDate = currentDate;
        }

        public SmartDateFormatter() : this(DateTime.Now)
        {

        }

        public String format(DateTime date)
        {
            if (date.Equals(currentDate))
                return TODAY;
            return ToDateFormat(date);
        }

        private string ToDateFormat(DateTime date)
        {
            return date.ToString(dateFormat);
        }


    }

    public interface SmartDateFormatterFactory
    {
        SmartDateFormatter of(DateTime currentDate);
        SmartDateFormatter ofCurrentDate();
    }

}