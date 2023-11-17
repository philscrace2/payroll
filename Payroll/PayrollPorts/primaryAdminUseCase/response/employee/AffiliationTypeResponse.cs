using PayrollEntities.affiliation;

namespace PayrollPorts.primaryAdminUseCase.response.employee
{
    public enum AffiliationTypeResponse
    {
        NO,
        UNION_MEMBER
    }


    public interface AffiliationTypeResponseFactory
    {
        AffiliationTypeResponse create(Affiliation affiliation);
    }

}


