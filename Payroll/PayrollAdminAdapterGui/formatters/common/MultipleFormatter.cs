namespace PayrollAdminAdapterGui.formatters.common
{
    public abstract class MultipleFormatter<T>
    {
        protected abstract String format(T element);
        public List<string> FormatAll<T>(List<T> elements)
        {
            return elements.Select(element => format(element)).ToList();
        }

    }

}