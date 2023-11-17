using Microsoft.Extensions.Logging;
using PayrollEntities;
using PayrollPorts.secondary.database;


namespace PayrollInteractors.pay.fullfill.fullfillers
{
    public class PaymasterPaymentFulfiller : PaymentFulfiller
    {

        private TransactionalRunner transactionalRunner;
        ILogger logger;

        public PaymasterPaymentFulfiller(TransactionalRunner transactionalRunner)
        {
            this.transactionalRunner = transactionalRunner;

            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = factory.CreateLogger("Program");
            logger.LogInformation("Hello World! Logging is {Description}.", "fun");
        }


        public void fulfillPayment(PayCheck payCheck)
        {
            transactionalRunner.ExecuteInTransaction(() =>
            {
                logger.LogInformation("(Fake) Paymaster payment record added for:" + payCheck);
            });
        }

    }


}