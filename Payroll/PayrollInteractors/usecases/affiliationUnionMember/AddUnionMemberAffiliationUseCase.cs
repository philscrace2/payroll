using PayrollEntities;
using PayrollEntities.affiliation;
using PayrollPorts.primaryAdminUseCase.request.changemployee;
using PayrollPorts.primaryAdminUseCase.request.changemployee.affiliation;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.affiliationUnionMember
{
    public class AddUnionMemberAffiliationUseCase : EmployeeGatewayCommandUseCase<AddUnionMemberAffiliationRequest>
    {


        private AffiliationFactory affiliationFactory;
        private AddUnionMemberAffiliationRequest request;

        public AddUnionMemberAffiliationUseCase(
                TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway,
                AffiliationFactory affiliationFactory
                ) : base(transactionalRunner, employeeGateway)
        {

            this.affiliationFactory = affiliationFactory;
        }


        protected override void ExecuteInTransaction(AddUnionMemberAffiliationRequest request)
        {
            this.request = request;
            Validator validator = new Validator(this.request, employeeGateway);
            employeeGateway.findById(request.employeeId)
                .setAffiliation(affiliationFactory.unionMemberAffiliation(request.unionMemberId, request.weeklyDueAmount));
        }

        public sealed class Validator
        {
            private readonly EmployeeGateway employeeGateway;

            public Validator(AddUnionMemberAffiliationRequest request, EmployeeGateway employeeGateway)
            {
                validateUnionMemberIdNotExists(request.unionMemberId);
                this.employeeGateway = employeeGateway;
            }

            private void validateUnionMemberIdNotExists(int unionMemberId)
            {
                if (employeeGateway.isEmployeeExistsByUnionMemberId(unionMemberId))
                {
                    Employee ownerEmployee = employeeGateway.findById(employeeGateway.findEmployeeIdByUnionMemberId(unionMemberId));
                    throw new UnionMemberIdAlreadyExistsException(ownerEmployee.getId(), ownerEmployee.getName());
                }
            }
        }


    }


}