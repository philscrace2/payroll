using PayrollPorts.primaryAdminUseCase.factories;

namespace PayrollPorts.primaryAdminUseCase
{
    public interface UseCaseFactories :
        AddEmployeeUseCaseFactory,
        ChangeToAbstractPaymentMethodUseCaseFactory,
        GetUnionMemberAffiliationUseCaseFactory,
        AddUnionMemberAffiliationUseCaseFactory,
        RemoveUnionMemberAffiliationUseCaseFactory,
        ChangeEmployeeUseCaseFactory,
        AddSalesReceiptUseCaseFactory,
        AddServiceChargeUseCaseFactory,
        AddTimeCardUseCaseFactory,
        UpdateTimeCardUseCaseFactory,
        DeleteEmployeeUseCaseFactory,
        PayListUseCaseFactory,
        PaymentFulfillUseCaseFactory,
        EmployeeListUseCaseFactory,
        GetEmployeeUseCaseFactory
    {
    }
}
