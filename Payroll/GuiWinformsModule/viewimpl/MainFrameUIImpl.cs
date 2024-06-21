using PayrollAdminAdapterGui.views_controllers_uis.mainframe;
using PayrollGuiWinformsImpl.viewimpl.mainframe;

namespace PayrollGuiWinformsImpl.viewimpl
{
    public class MainFrameUIImpl : MainFrameUI
    {
        public readonly MainFrameWindow view;
        private readonly StatusBarUIImpl statusBarUiImpl;
        private MainPanelUIImpl mainPanelUiImpl;


        public MainFrameUIImpl(MainPanelUIImpl mainPanelUiImpl, StatusBarUIImpl statusBarUiImpl)
        {
            this.statusBarUiImpl = statusBarUiImpl;

            view = new MainFrameWindow(mainPanelUiImpl.getView(), statusBarUiImpl.getView());
        }

        public void show()
        {
            view.ShowIt();
        }

    }
}
