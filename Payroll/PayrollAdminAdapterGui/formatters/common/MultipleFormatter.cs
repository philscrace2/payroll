namespace PayrollAdminAdapterGui.formatters.common
{
    public abstract class MultipleFormatter
    {
        protected abstract String format(string element);
        public List<string> FormatAll(List<string> elements)
        {
            return elements.Select(element => format(element)).ToList();
        }

    }

}