using PayrollAdminAdapterGui.formatters.common;
using PayrollPorts.primaryAdminUseCase.response.employee;

namespace PayrollAdminAdapterGui.formatters.usecase.response
{
    public class PaymentMethodTypeResponseToStringFormatter : ThrowMap<PaymentMethodTypeResponse, string>
    {
        public PaymentMethodTypeResponseToStringFormatter()
        {
            Put(PaymentMethodTypeResponse.DIRECT, "Direct");
            Put(PaymentMethodTypeResponse.PAYMASTER, "Paymaster hold");
        }

        public string Format(PaymentMethodTypeResponse response)
        {
            return GetOrThrow(response);
        }
    }


}