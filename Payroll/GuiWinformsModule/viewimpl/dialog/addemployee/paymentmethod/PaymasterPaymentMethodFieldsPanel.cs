using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.addemployee.paymentmethod
{
    public class PaymasterPaymentMethodFieldsPanel: PaymentMethodFieldsPanel<PaymentMethod>
    {
        public PaymasterPaymentMethodFieldsPanel()
        {
            //setBorder(new EtchedBorder(EtchedBorder.LOWERED, null, null));
        }

        public override PaymasterPaymentMethod getModel()
        {
            return new PaymasterPaymentMethod();
        }
    }
}
