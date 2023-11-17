using PayrollEntities;
using PayrollEntities.paymentmethod;
using PayrollInteractors.pay.fullfill.fullfillers;
using PayrollPorts.secondary.banktransfer;

namespace PayrollInteractors.usecases.pay.fullfill.fullfillers
{
    public class DirectPaymentFulfiller : PaymentFulfiller
    {
        private BankTransferPort bankTransferPort;
        private DirectPaymentMethod directPaymentMethod;

        public DirectPaymentFulfiller(
                BankTransferPort bankTransferPort,
                DirectPaymentMethod directPaymentMethod
                )
        {
            this.bankTransferPort = bankTransferPort;
            this.directPaymentMethod = directPaymentMethod;
        }


        public void fulfillPayment(PayCheck payCheck)
        {
            bankTransferPort.pay(payCheck.getNetAmount(), directPaymentMethod.getAccountNumber());
        }


    }


}