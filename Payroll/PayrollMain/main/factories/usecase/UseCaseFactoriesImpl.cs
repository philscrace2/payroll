using PayrollInteractors.pay.fullfill;
using PayrollInteractors.usecases.affiliation.unionmember;
using PayrollInteractors.usecases.commisioned;
using PayrollInteractors.usecases.employee;
using PayrollInteractors.usecases.employee.add;
using PayrollInteractors.usecases.employee.change;
using PayrollInteractors.usecases.employee.change.paymentmethod;
using PayrollInteractors.usecases.employee.find;
using PayrollInteractors.usecases.employee.list;
using PayrollInteractors.usecases.hourly;
using PayrollInteractors.usecases.pay.paylist;
using PayrollMain.main.factories.response;
using PayrollPorts.primaryAdminUseCase;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.request.addemployee;
using PayrollPorts.primaryAdminUseCase.request.changemployee;
using PayrollPorts.primaryAdminUseCase.request.changemployee.affiliation;
using PayrollPorts.primaryAdminUseCase.request.changemployee.paymentmethod;
using PayrollPorts.primaryAdminUseCase.request.hourly;
using PayrollPorts.primaryAdminUseCase.response;
using PayrollPorts.primaryAdminUseCase.response.employee;
using PayrollPorts.secondary.banktransfer;
using PayrollPorts.secondary.database;

namespace PayrollMain.main.factories.usecase
{
    public class UseCaseFactoriesImpl : UseCaseFactories
    {

        private EmployeeGateway employeeGateway;
        private TransactionalRunner transactionalRunner;
        private EntityFactory entityFactory;

        private BankTransferPort bankTransferPort;

        //@Inject
        private AffiliationTypeResponseFactory affiliationTypeResponseFactory;


        /** use {@link PayrollModule} to instantiate **/
        //@Inject
        public UseCaseFactoriesImpl(
            Database database,
            BankTransferPort bankTransferPort
            )
        {
            this.transactionalRunner = database.transactionalRunner();
            this.employeeGateway = database.employeeGateway();
            this.entityFactory = database.entityFactory();
            this.bankTransferPort = bankTransferPort;
        }

        public CommandUseCase<AddSalariedEmployeeRequest> addSalariedEmployeeUseCase()
        {
            return new AddSalariedEmployeeUseCase(transactionalRunner, employeeGateway, entityFactory, entityFactory, entityFactory, entityFactory, entityFactory);
        }


        public CommandUseCase<AddHourlyEmployeeRequest> addHourlyEmployeeUseCase()
        {
            return new AddHourlyEmployeeUseCase(transactionalRunner, employeeGateway, entityFactory, entityFactory, entityFactory, entityFactory, entityFactory);
        }


        public CommandUseCase<AddCommissionedEmployeeRequest> addCommissionedEmployeeUseCase()
        {
            return new AddCommissionedEmployeeUseCase(transactionalRunner, employeeGateway, entityFactory, entityFactory, entityFactory, entityFactory, entityFactory);
        }


        public CommandUseCase<AddTimeCardRequest> addTimeCardUseCase()
        {
            return new AddTimeCardUseCase(transactionalRunner, employeeGateway, entityFactory);
        }


        public CommandUseCase<UpdateTimeCardRequest> updateTimeCardUseCase()
        {
            return new UpdateTimeCardUseCase(transactionalRunner, employeeGateway);
        }


        public IFunctionUseCase<GetUnionMemberAffiliationRequest, GetUnionMemberAffiliationResponse> getUnionMemberAffiliationUseCase()
        {
            return new GetUnionMemberAffiliationUseCase(transactionalRunner, employeeGateway);
        }


        public CommandUseCase<AddUnionMemberAffiliationRequest> addUnionMemberAffiliationUseCase()
        {
            return new AddUnionMemberAffiliationUseCase(transactionalRunner, employeeGateway, entityFactory);
        }


        public CommandUseCase<RemoveUnionMemberAffiliationRequest> removeUnionMemberAffiliationUseCase()
        {
            return new RemoveUnionMemberAffiliationUseCase(transactionalRunner, employeeGateway, entityFactory);
        }


        public CommandUseCase<ChangeEmployeeNameRequest> changeEmployeeNameUseCase()
        {
            return new ChangeEmployeeNameUseCase(transactionalRunner, employeeGateway);
        }


        public CommandUseCase<AddSalesReceiptRequest> addSalesReceiptUseCaseFactory()
        {
            return new AddSalesReceiptUseCase(transactionalRunner, employeeGateway, entityFactory);
        }


        public CommandUseCase<AddServiceChargeRequest> addServiceChargeUseCase()
        {
            return new AddServiceChargeUseCase(transactionalRunner, employeeGateway, entityFactory);
        }


        public CommandUseCase<DeleteEmployeeRequest> deleteEmployeeUseCase()
        {
            return new DeleteEmployeeUseCase(transactionalRunner, employeeGateway);
        }


        public IFunctionUseCase<PayListRequest, PayListResponse> payListUseCase()
        {
            return new PayListUseCase(transactionalRunner, employeeGateway);
        }


        public IFunctionUseCase<EmployeeListRequest, EmployeeListResponse> employeeListUseCase()
        {
            return new EmployeeListUseCase(transactionalRunner, employeeGateway, new AffiliationTypeResponseFactoryImpl());
        }


        public IFunctionUseCase<GetEmployeeRequest, GetEmployeeResponse> getEmployeeUseCase()
        {
            return new GetEmployeeUseCase(transactionalRunner, employeeGateway);
        }


        public IFunctionUseCase<PaymentFulfillRequest, PaymentFulfillResponse> paymentFulfillUseCase()
        {
            return new PaymentFulfillUseCase(employeeGateway, transactionalRunner, bankTransferPort);
        }


        public CommandUseCase<ChangeToDirectPaymentMethodRequest> changeToDirectPaymentMethodUseCase()
        {
            return new ChangeToDirectPaymentMethodUseCase(transactionalRunner, employeeGateway, entityFactory);
        }


        public CommandUseCase<ChangeEmployeeRequest> changeToPaymasterPaymentMethodUseCase()
        {
            return new ChangeToPaymasterPaymentMethodUseCase(transactionalRunner, employeeGateway, entityFactory);
        }

    }
}
