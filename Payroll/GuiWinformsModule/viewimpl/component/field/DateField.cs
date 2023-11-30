namespace PayrollGuiWinformsImpl.viewimpl.component.field
{
    public class DateField : DateTimePicker
    {
        public DateField(string dateFormat)
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = dateFormat;
        }

        public DateTime? GetDate()
        {
            return Value;
        }

        public void SetDate(DateTime? date)
        {
            if (date.HasValue)
            {
                Value = date.Value;
            }
            else
            {
                // Handle the case where the date is null.
                // DateTimePicker cannot represent a null value, so you might need to handle this differently,
                // for example, by hiding the control, showing a default value, or using a nullable flag.
            }
        }

        // Deprecated methods from the Java version are not required in C#
        // since the standard getters and setters are used in C#
    }

}
