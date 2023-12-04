using Ninject;
using PayrollAdminAdapterGui.views_controllers_uis.mainframe;
using PayrollPorts.primaryAdminUseCase;
using PayrollPorts.secondary.database;

namespace PayrollGuiWinformsImpl
{
    public class GuiWinformsImpl : Executable
    {
        private MainFrameUI mainFrameUI;

        public GuiWinformsImpl(UseCaseFactories useCaseFactories)
        {
            IKernel kernel = new StandardKernel(new GuiWinformsModule(useCaseFactories));
            mainFrameUI = kernel.Get<MainFrameUI>();
        }
        public void run()
        {
            mainFrameUI.show();
            Form f = new Form();
            // f.ShowDialog();
        }

    }
}
