using PayrollEntities;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;
using PayrollPorts.primaryAdminUseCase.response.employee;
using PayrollPorts.secondary.database;
using static PayrollPorts.primaryAdminUseCase.response.employee.paymenttype.PaymentTypeResponse;
using static PayrollPorts.primaryAdminUseCase.response.EmployeeListResponse;

namespace PayrollInteractors.usecases.employee.list
{
    public class EmployeeListUseCase : EmployeeGatewayFunctionUseCase<EmployeeListRequest, EmployeeListResponse>
    {
        private AffiliationTypeResponseFactory affiliationTypeResponseFactory;

        public EmployeeListUseCase(
        TransactionalRunner transactionalRunner,
        EmployeeGateway employeeGateway,
                AffiliationTypeResponseFactory affiliationTypeResponseFactory
                ) : base(transactionalRunner, employeeGateway)
        {

            this.affiliationTypeResponseFactory = affiliationTypeResponseFactory;
        }

        protected override EmployeeListResponse ExecuteInTransaction(EmployeeListRequest request)
        {
            return new EmployeeListResponseCreator(request.currentDate).ToResponse(employeeGateway.findAll());
        }
    }

    public class EmployeeListResponseCreator
    {
        private readonly DateTime dateTime;
        private DateTime baseDate;
        private PaymentTypeResponseFactory paymentTypeResponseFactory = new PaymentTypeResponseFactory();
        AffiliationTypeResponseFactory affiliationTypeResponseFactory;

        public EmployeeListResponseCreator(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public EmployeeListResponseCreator(DateTime baseDate, AffiliationTypeResponseFactory affiliationTypeResponseFactory)
        {
            this.baseDate = baseDate;
            this.affiliationTypeResponseFactory = affiliationTypeResponseFactory;
        }

        public EmployeeListResponse ToResponse(IEnumerable<Employee> employees)
        {
            return new EmployeeListResponse(
                employees.Select(employee => ToResponse(employee)).ToList<EmployeeForEmployeeListResponse>()
            );
        }

        private EmployeeForEmployeeListResponse ToResponse(Employee employee)
        {
            EmployeeForEmployeeListResponse response = new EmployeeForEmployeeListResponse();
            response.id = employee.getId();
            response.name = employee.getName();
            response.address = employee.getAddress();
            response.paymentTypeResponse = employee.getPaymentType().accept(paymentTypeResponseFactory);
            response.affiliationTypeResponse = affiliationTypeResponseFactory.create(employee.getAffiliation());
            response.nextPayDay = employee.getPaymentSchedule().getSameOrNextPayDate(baseDate);
            return response;
        }

    }


}