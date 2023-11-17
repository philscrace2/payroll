namespace PayrollPorts.primaryAdminUseCase.request.changemployee.affiliation
{
    public class RemoveUnionMemberAffiliationRequest : Request
    {
        public int unionMemberId;

        public RemoveUnionMemberAffiliationRequest(int unionMemberId)
        {
            this.unionMemberId = unionMemberId;
        }
    }

}