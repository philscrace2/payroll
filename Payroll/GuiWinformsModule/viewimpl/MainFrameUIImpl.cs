﻿using PayrollAdminAdapterGui.views_controllers_uis.mainframe;
using PayrollGuiWinformsImpl.viewimpl.mainframe;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel.employeemanager.affiliation;

namespace PayrollGuiWinformsImpl.viewimpl
{
    public class MainFrameUIImpl : MainFrameUI
    {
        public readonly MainFrameWindow mainFrameWindow;
        public MainFrameUIImpl(MainPanelUIImpl mainPanelUiImpl, StatusBarUIImpl statusBarUiImpl)
        {
            mainFrameWindow = new MainFrameWindow(new MainPanel(new EmployeeManagerPanel(new EmployeeListPanel(), new AffiliationButtonViewImpl()), new PayPanel()), new StatusBarPanel());
        }
        public void show()
        {
            throw new NotImplementedException();
        }
    }
}