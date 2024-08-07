﻿using PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel;
using PayrollGuiWinformsImpl.viewimpl.mainframe.mainpanel;

namespace PayrollGuiWinformsImpl.viewimpl.mainframe
{
    public class MainPanelUIImpl : MainPanelUI<MainPanel>
    {
        public MainPanelUIImpl(
            MainPanelController<MainPanel> controller,
            EmployeeManagerUIImpl<EmployeeManagerPanel> employeeManagerUIImpl,
            PayUIImpl<PayPanel> payUIImpl
        ) : base(controller, new MainPanel(employeeManagerUIImpl.getView(), payUIImpl.getView()), employeeManagerUIImpl, payUIImpl)
        {

        }

    }
}
