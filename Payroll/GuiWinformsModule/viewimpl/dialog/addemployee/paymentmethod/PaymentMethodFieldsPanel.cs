﻿using PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollGuiWinformsImpl.viewimpl.dialog.addemployee.paymentmethod
{
    public class PaymentMethodFieldsPanel<T> : FieldsPanel where T : PaymentMethod
    {
        public PaymentMethodFieldsPanel()
        {
            //setBorder(new EtchedBorder(EtchedBorder.LOWERED, null, null));
        }

        public virtual PaymentMethod getModel()
        {
            //return default(T);

            return new PaymasterPaymentMethod();
        }


    }
}
