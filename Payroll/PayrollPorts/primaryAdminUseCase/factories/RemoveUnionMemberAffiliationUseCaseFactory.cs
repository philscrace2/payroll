using PayrollPorts.primaryAdminUseCase.request.changemployee.affiliation;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface RemoveUnionMemberAffiliationUseCaseFactory
    {
        CommandUseCase<RemoveUnionMemberAffiliationRequest> removeUnionMemberAffiliationUseCase();
    }

}