namespace PayrollPorts.primaryAdminUseCase.request
{
    public class GetUnionMemberAffiliationRequest : Request
    {
        public int? employeeId;
        public GetUnionMemberAffiliationRequest(int? employeeId)
        {
            this.employeeId = employeeId;
        }
    }

}
