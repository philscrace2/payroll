namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel
{
    public class MainPanelController : AbstractController, MainPanelViewListener, MainPanelView
    {
        private ObservableValue<DateTime> observableCurrentDate = new ObservableValue<DateTime>();

        public MainPanelController() : base()
        {
        }

        public void setDefaultModelToView()
        {
            MainPanelView mpv = (MainPanelView)this.GetView();
            mpv.setModel(new MainPanelViewModel(getDefaultDate()));
        }

        private DateTime getDefaultDate()
        {
            return DateTime.Now;
            //		return LocalDate.of(2016, 4, 14); //DEBUG
            //		return LocalDate.of(2016, 4, 15); //DEBUG
        }

        public Observable<DateTime> getObservableCurrentDate()
        {
            return observableCurrentDate;
        }


        public void onChangedCurrentDate()
        {
            MainPanelView mpv = (MainPanelView)this.GetView();
            observableCurrentDate.set(mpv.getModel().currentDate);
        }


        protected override ViewListener GetViewListener()
        {
            return (MainPanelViewListener)this;
        }

        public void setViewListener(MainPanelViewListener listener)
        {
            throw new NotImplementedException();
        }

        public void setViewListener(ViewListener getViewListener)
        {
            throw new NotImplementedException();
        }

        public void setModel(MainPanelViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public MainPanelViewModel getModel()
        {
            throw new NotImplementedException();
        }
    }

}