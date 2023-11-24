namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.common.error
{
    public class ErrorDialogController<V> : AbstractDialogViewController<V, CloseableViewListener> where V : ErrorDialogView
    {
        public void SetThrowable(Exception throwable)
        {
            GetView().setModel(new Presenter().ToViewModel(throwable));
        }

        protected override bool OnCloseActionShouldCloseAutomatically()
        {
            return true;
        }

        protected override CloseableViewListener GetViewListener()
        {
            return this;
        }

        private class Presenter
        {
            public ErrorViewModel ToViewModel(Exception throwable)
            {
                using (StringWriter stringWriter = new StringWriter())
                {
                    stringWriter.WriteLine(throwable.Message);
                    stringWriter.WriteLine(throwable.StackTrace);

                    Exception innerException = throwable.InnerException;
                    while (innerException != null)
                    {
                        stringWriter.WriteLine("Inner Exception:");
                        stringWriter.WriteLine(innerException.Message);
                        stringWriter.WriteLine(innerException.StackTrace);
                        innerException = innerException.InnerException;
                    }

                    return new ErrorViewModel(stringWriter.ToString());
                }
            }
        }
    }

}