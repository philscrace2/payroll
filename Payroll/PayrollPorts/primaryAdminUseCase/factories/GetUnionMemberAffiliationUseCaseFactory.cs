using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface GetUnionMemberAffiliationUseCaseFactory
    {
        IFunctionUseCase<GetUnionMemberAffiliationRequest, GetUnionMemberAffiliationResponse> getUnionMemberAffiliationUseCase();
    }

}