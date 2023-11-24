using PayrollEntities.paymentmethod;

namespace PayrollPorts.primaryAdminUseCase.response.employee
{
    public enum PaymentMethodTypeResponse
    {
        DIRECT,
        PAYMASTER
    }


    public class PaymentMethodTypeResponseFactory : PaymentMethod.IPaymentMethodVisitor<PaymentMethodTypeResponse>
    {
        public PaymentMethodTypeResponse visit(PaymasterPaymentMethod paymasterPaymentMethod)
        {
            return PaymentMethodTypeResponse.PAYMASTER;
        }


        public PaymentMethodTypeResponse visit(DirectPaymentMethod directPaymentMethod)
        {
            return PaymentMethodTypeResponse.DIRECT;
        }

    }

}


