using PayrollEntities;
using PayrollEntities.affiliation;
using PayrollPorts.primaryAdminUseCase.request.changemployee.affiliation;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.affiliationUnionMember
{
    public class RemoveUnionMemberAffiliationUseCase : EmployeeGatewayCommandUseCase<RemoveUnionMemberAffiliationRequest>
    {


        private AffiliationFactory affiliationFactory;

        public RemoveUnionMemberAffiliationUseCase(
                TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway,
                AffiliationFactory affiliationFactory
                ) : base(transactionalRunner, employeeGateway)
        {

            this.affiliationFactory = affiliationFactory;
        }


        protected override void ExecuteInTransaction(RemoveUnionMemberAffiliationRequest request)
        {
            getEmployeeByUnionMemberId(request.unionMemberId).setAffiliation(affiliationFactory.noAffiliation());
        }

        private Employee getEmployeeByUnionMemberId(int unionMemberId)
        {
            return employeeGateway.findById(employeeGateway.findEmployeeIdByUnionMemberId(unionMemberId));
        }

    }

}