using PayrollEntities.paymentmethod;
using PayrollInteractors.pay.fullfill.fullfillers;
using PayrollPorts.secondary.banktransfer;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.pay.fullfill.fullfillers
{
    public class PaymentFulfillerFactory : PaymentMethod.IPaymentMethodVisitor<PaymentFulfiller>
    {

        private BankTransferPort bankTransferPort;
        private TransactionalRunner transactionalRunner;

        public PaymentFulfillerFactory(
                BankTransferPort bankTransferPort,
                TransactionalRunner transactionalRunner
                )
        {
            this.bankTransferPort = bankTransferPort;
            this.transactionalRunner = transactionalRunner;
        }

        public PaymentFulfiller visit(PaymasterPaymentMethod paymasterPaymentMethod)
        {
            return new PaymasterPaymentFulfiller(transactionalRunner);
        }


        public PaymentFulfiller visit(DirectPaymentMethod directPaymentMethod)
        {
            return new DirectPaymentFulfiller(bankTransferPort, directPaymentMethod);
        }

    }


}