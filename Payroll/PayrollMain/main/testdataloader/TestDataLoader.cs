using PayrollPorts.primaryAdminUseCase;
using PayrollPorts.primaryAdminUseCase.request.addemployee;
using PayrollPorts.primaryAdminUseCase.request.changemployee.paymentmethod;
using PayrollPorts.secondary.database;

namespace PayrollMain.main.testdataloader
{
    public class TestDataLoader
    {

        public void clearDatabaseAndInsertTestData(Database database, UseCaseFactories useCaseFactories)
        {
            clearDatabase(database);
            insertTestEmployees(useCaseFactories);
        }

        private void clearDatabase(Database database)
        {
            database.transactionalRunner().ExecuteInTransaction(() =>
                database.employeeGateway().deleteAll()
            );
        }

        private void insertTestEmployees(UseCaseFactories useCaseFactories)
        {
            useCaseFactories.addSalariedEmployeeUseCase()
                .Execute(new AddSalariedEmployeeRequest(1, "Stuart Dueton", "10 Rue Bailleul, Paris", 3000));
            useCaseFactories.addHourlyEmployeeUseCase()
                .Execute(new AddHourlyEmployeeRequest(2, "Stéphane Toudret", "7 Rue du Joinville 75019, Paris", 21));
            useCaseFactories.addHourlyEmployeeUseCase()
                .Execute(new AddHourlyEmployeeRequest(3, "John Merceland", "Ovari u. 45, 1092 Budapest", 25));
            useCaseFactories.addCommissionedEmployeeUseCase().Execute(
                new AddCommissionedEmployeeRequest(5, "Jean-Paul Pham", "23 Rue de Crimée, Paris", 1650, 0.15d));

            //Paymentmethods
            useCaseFactories.changeToDirectPaymentMethodUseCase()
                .Execute(new ChangeToDirectPaymentMethodRequest(1, "16200223-10041865"));
            useCaseFactories.changeToDirectPaymentMethodUseCase()
                .Execute(new ChangeToDirectPaymentMethodRequest(2, "16200010-10001040"));
        }


    }


}
