namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel
{
    public interface MainPanelView :
    ControlView<MainPanelViewListener>,
    ModelConsumer<MainPanelViewModel>,
    ModelProducer<MainPanelViewModel>
    {

    }

    public interface MainPanelViewListener
    {
        void onChangedCurrentDate();
    }

    public class MainPanelViewModel
    {
        public DateTime currentDate;
        public MainPanelViewModel(DateTime currentDate)
        {
            this.currentDate = currentDate;
        }
    }

}