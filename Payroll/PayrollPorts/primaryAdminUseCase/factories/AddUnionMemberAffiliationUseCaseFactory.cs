using PayrollPorts.primaryAdminUseCase.request.changemployee;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface AddUnionMemberAffiliationUseCaseFactory
    {
        CommandUseCase<AddUnionMemberAffiliationRequest> addUnionMemberAffiliationUseCase();
    }

}