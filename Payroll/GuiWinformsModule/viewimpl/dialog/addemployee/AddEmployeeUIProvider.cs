using Ninject.Activation;
using System;
using System.Collections.Generic;
using Ninject;
using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;


namespace PayrollGuiWinformsImpl.viewimpl.dialog.addemployee
{
    public class AddEmployeeUIProvider : IProvider<AddEmployeeUI<AddEmployeeView>>
    {
        public object Create(IContext context)
        {
            var controller = context.Kernel.Get<AddEmployeeController<AddEmployeeView>>();
            return new AddEmployeeUIImpl<AddEmployeeView>(controller);
        }

        public Type Type => typeof(AddEmployeeUI<AddEmployeeView>);
    }
}
