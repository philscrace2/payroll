using PayrollPorts.secondary.banktransfer;

namespace PayrollMain.adapters.secondary.banktransfer
{
    public class FakeBankTransferPort : BankTransferPort
    {
        //private Log log = LogFactory.getLog(getClass());

        public void pay(int amount, String accountNumber)
        {
            //log.info(String.Format("(Fake) Amount %s transferred to account %s", amount, accountNumber));
        }

        public void pay(int? amount, string accountNumber)
        {
            throw new NotImplementedException();
        }
    }
}
