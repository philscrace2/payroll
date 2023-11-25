using PayrollEntities.affiliation;
using PayrollPorts.primaryAdminUseCase.response.employee;

namespace PayrollMain.main.factories.response
{
    public class AffiliationTypeResponseFactoryImpl : AffiliationTypeResponseFactory
    {
        public AffiliationTypeResponse create(Affiliation affiliation)
        {
            if (affiliation is NoAffiliation)
                return AffiliationTypeResponse.NO;
            if (affiliation is UnionMemberAffiliation)
                return AffiliationTypeResponse.UNION_MEMBER;
            throw new Exception("not implemented");
        }

    }
}
