// See https://aka.ms/new-console-template for more information
//case1();

using PayrollDBAdapterJPA;
using PayrollMain;


namespace PayrollMain
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            case1();
        }

        public static void case2()
        {
            Payroll.builder()
                .withDatabaseJPA(JPAPersistenceUnit.HSQL_DB)
                .withBankTransferPortFake()
                .withLoadedTestData()
                .buildGuiAdminSwing()
                .run();
        }

        public static void case1()
        {
            Payroll.builder()
                .withDatabaseInMemory()
                .withBankTransferPortFake()
                .withLoadedTestData()
                .buildGuiAdminSwing()
                .run();
        }
    }
}
