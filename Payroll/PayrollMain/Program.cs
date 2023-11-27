// See https://aka.ms/new-console-template for more information
//case1();

using PayrollMain;

case2();

void case2()
{
    Payroll.builder()
        .withDatabaseJPA(JPAPersistenceUnit.HSQL_DB)
        .withBankTransferPortFake()
        .withLoadedTestData()
        .buildGuiAdminSwing()
        .run();
}

void case1()
{
    throw new NotImplementedException();
}
