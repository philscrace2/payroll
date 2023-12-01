using PayrollAdminAdapterGui.views_controllers_uis.mainframe;
using PayrollGuiWinformsImpl.viewimpl.mainframe;

namespace PayrollGuiWinformsImpl.viewimpl
{
    public class MainFrameUIImpl : MainFrameUI
    {
        public readonly PayrollGuiWinformsImpl.MainFrameWindow mainFrameWindow;
        public MainFrameUIImpl(MainPanelUIImpl mainPanelUiImpl, StatusBarUIImpl statusBarUiImpl)
        {
            mainFrameWindow = new PayrollGuiWinformsImpl.MainFrameWindow(mainPanelUiImpl.getView(), statusBarUiImpl.getView());
        }
        public void show()
        {
            mainFrameWindow.ShowIt();
        }
    }
}
