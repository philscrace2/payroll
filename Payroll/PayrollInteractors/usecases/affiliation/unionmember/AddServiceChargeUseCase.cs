using PayrollEntities;
using PayrollEntities.affiliation;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.request.changemployee.affiliation;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.affiliation.unionmember
{

    public class AddServiceChargeUseCase : EmployeeGatewayCommandUseCase<AddServiceChargeRequest>
    {
        private readonly ServiceChargeFactory serviceChargeFactory;

        public AddServiceChargeUseCase(TransactionalRunner transactionalRunner, EmployeeGateway employeeGateway, ServiceChargeFactory serviceChargeFactory) : base(transactionalRunner, employeeGateway)
        {
            this.serviceChargeFactory = serviceChargeFactory;
        }

        protected override void ExecuteInTransaction(AddServiceChargeRequest request)
        {
            Employee employee = getEmployeeByUnionMemberId(request.unionMemberId);

            UnionMemberAffiliation unionMemberAffiliation = castUnionMemberAffiliation(employee.getAffiliation());
            unionMemberAffiliation.addServiceCharge(createServiceCharge(request));
        }

        private Employee getEmployeeByUnionMemberId(int unionMemberId)
        {
            return employeeGateway.findById(employeeGateway.findEmployeeIdByUnionMemberId(unionMemberId));
        }

        private UnionMemberAffiliation castUnionMemberAffiliation(Affiliation affiliation)
        {
            if (affiliation is UnionMemberAffiliation)
            {
                return (UnionMemberAffiliation)affiliation;
            }
            else
            {
                throw new NotUnionMemberException();
            }
        }

        private ServiceCharge createServiceCharge(AddServiceChargeRequest request)
        {
            return serviceChargeFactory.serviceCharge(request.date, request.amount);
        }

    }

}