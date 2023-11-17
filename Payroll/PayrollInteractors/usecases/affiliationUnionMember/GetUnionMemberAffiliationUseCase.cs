using PayrollEntities;
using PayrollEntities.affiliation;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.request.changemployee.affiliation;
using PayrollPorts.primaryAdminUseCase.response;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.affiliationUnionMember
{
    public class GetUnionMemberAffiliationUseCase :
        EmployeeGatewayFunctionUseCase<GetUnionMemberAffiliationRequest, GetUnionMemberAffiliationResponse>
    {


        public GetUnionMemberAffiliationUseCase(
                TransactionalRunner transactionalRunner,
        EmployeeGateway employeeGateway
                ) : base(transactionalRunner, employeeGateway)
        {

        }


        protected override GetUnionMemberAffiliationResponse ExecuteInTransaction(GetUnionMemberAffiliationRequest request)
        {
            Employee employee = employeeGateway.findById(request.employeeId);
            return toResponse(employee, getUnionMemberAffiliation(employee));
        }

        private UnionMemberAffiliation getUnionMemberAffiliation(Employee employee)
        {
            Affiliation affiliation = employee.getAffiliation();
            if (affiliation is UnionMemberAffiliation)
                return (UnionMemberAffiliation)affiliation;

            else
                throw new NotUnionMemberException();
        }

        private GetUnionMemberAffiliationResponse toResponse(Employee employee, UnionMemberAffiliation unionMemberAffiliation)
        {
            GetUnionMemberAffiliationResponse response = new GetUnionMemberAffiliationResponse();
            response.employeeId = employee.getId();
            response.unionMemberId = unionMemberAffiliation.getUnionMemberId();
            response.weeklyDueAmount = unionMemberAffiliation.getWeeklyDueAmount();
            return response;
        }

    }

}