using PayrollEntities.paymentmethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.addemployee.paymentmethod
{
    public abstract class PaymentMethodFieldsPanel<T> where T : PaymentMethod
    {

    public PaymentMethodFieldsPanel()
    {
        //setBorder(new EtchedBorder(EtchedBorder.LOWERED, null, null));
    }

    public abstract T getModel();
}
}
