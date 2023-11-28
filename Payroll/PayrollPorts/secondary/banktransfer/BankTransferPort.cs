namespace PayrollPorts.secondary.banktransfer
{
    public interface BankTransferPort
    {
        void pay(int? amount, String accountNumber);
    }
}
