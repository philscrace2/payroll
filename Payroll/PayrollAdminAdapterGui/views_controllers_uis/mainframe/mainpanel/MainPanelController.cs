namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel
{
    public class MainPanelController :
        AbstractController<MainPanelView, MainPanelViewListener>, MainPanelViewListener
    {
        private ObservableValue<DateTime> observableCurrentDate = new ObservableValue<DateTime>();

        public void setDefaultModelToView()
        {
            GetView().setModel(new MainPanelViewModel(getDefaultDate()));
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
            observableCurrentDate.set(GetView().getModel().currentDate);
        }


        protected override MainPanelViewListener GetViewListener()
        {
            return this;
        }

    }

}