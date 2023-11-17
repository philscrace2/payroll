namespace PayrollPorts.secondary.database
{
    public interface Database
    {
        TransactionalRunner transactionalRunner();
        EntityFactory entityFactory();
        EmployeeGateway employeeGateway();

    }
}
