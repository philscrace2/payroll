using PayrollPorts.primaryAdminUseCase.request;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface AddSalesReceiptUseCaseFactory
    {
        CommandUseCase<AddSalesReceiptRequest> addSalesReceiptUseCaseFactory();
    }


}