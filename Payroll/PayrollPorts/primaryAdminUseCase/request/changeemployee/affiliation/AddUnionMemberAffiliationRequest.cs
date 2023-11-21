namespace PayrollPorts.primaryAdminUseCase.request.changemployee
{
    public class AddUnionMemberAffiliationRequest : ChangeEmployeeRequest
    {

        public int? unionMemberId;
        public int? weeklyDueAmount;

        public AddUnionMemberAffiliationRequest(int employeeId, int? unionMemberId, int? weeklyDueAmount) : base(employeeId)
        {

            this.unionMemberId = unionMemberId;
            this.weeklyDueAmount = weeklyDueAmount;
        }
    }
}