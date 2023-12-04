namespace PayrollAdminAdapterGui.views_controllers_uis
{
    public class ObservableValue<T> : Observable<T>
    {
        private T value;
        private List<ChangeListener<T>> changeListeners = new List<ChangeListener<T>>();

        public ObservableValue(T initialValue)
        {
            this.value = initialValue;
        }

        public ObservableValue()
        {

        }

        public void set(T value)
        {
            this.value = value;
            notifyListeners();
        }

        private void notifyListeners()
        {
            changeListeners.ForEach(
                l => l.onChanged(value)
            );
        }

        public T get()
        {
            return value;
        }


        public void addChangeListener(ChangeListener<T> changeListener)
        {
            changeListeners.Add(changeListener);
        }
    }

}
