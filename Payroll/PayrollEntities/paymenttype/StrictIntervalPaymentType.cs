namespace PayrollEntities.paymenttype
{
    public abstract class StrictIntervalPaymentType : PaymentType
    {
        public override int? calculateAmount(DateInterval dateInterval)
        {
            validate(dateInterval);
            return calculateAmountOnValidatedInterval(dateInterval);
        }

        private void validate(DateInterval dateInterval)
        {
            if (!isValidInterval(dateInterval))
                throw new InvalidIntervalException();
        }

        protected abstract bool isValidInterval(DateInterval dateInterval);

        protected abstract int? calculateAmountOnValidatedInterval(DateInterval dateInterval);

        public class InvalidIntervalException : Exception { }
    }



}







