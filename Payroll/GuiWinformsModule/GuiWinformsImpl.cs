using PayrollAdminAdapterGui.views_controllers_uis.mainframe;
using PayrollPorts.primaryAdminUseCase;
using PayrollPorts.secondary.database;

namespace GuiWinformsModule
{
    public class GuiWinformsImpl : Executable
    {

        private MainFrameUI mainFrameUI;

        public GuiWinformsImpl(UseCaseFactories useCaseFactories)
        {
            //mainFrameUI = Guice.createInjector(new GuiWinformsModule()).getInstance(MainFrameUI);
        }


        public void run()
        {
            mainFrameUI.show();
        }

    }
}
