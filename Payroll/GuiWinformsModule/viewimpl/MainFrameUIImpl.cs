using PayrollAdminAdapterGui.views_controllers_uis.mainframe;
using PayrollGuiWinformsImpl.viewimpl.mainframe;

namespace PayrollGuiWinformsImpl.viewimpl
{
    public class MainFrameUIImpl : MainFrameUI
    {
        private readonly StatusBarUIImpl statusBarUiImpl;
        public PayrollGuiWinformsImpl.MainFrameWindow mainFrameWindow;
        private MainPanelUIImpl mainPanelUiImpl;


        public MainFrameUIImpl(MainPanelUIImpl mainPanelUiImpl, StatusBarUIImpl statusBarUiImpl)
        {
            this.statusBarUiImpl = statusBarUiImpl;

            mainFrameWindow = new PayrollGuiWinformsImpl.MainFrameWindow(mainPanelUiImpl.getView(), statusBarUiImpl.getView());
        }

        public void show()
        {
            mainFrameWindow.ShowIt();
        }

    }
}
