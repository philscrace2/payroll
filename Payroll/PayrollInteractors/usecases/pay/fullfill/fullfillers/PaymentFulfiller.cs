using PayrollEntities;

namespace PayrollInteractors.pay.fullfill.fullfillers
{
    public interface PaymentFulfiller
    {
        void fulfillPayment(PayCheck payCheck);
    }
}