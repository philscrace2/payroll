using PayrollEntities;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;
using PayrollPorts.primaryAdminUseCase.response.employee;
using PayrollPorts.secondary.database;
using static PayrollPorts.primaryAdminUseCase.response.employee.paymenttype.PaymentTypeResponse;

namespace PayrollInteractors.usecases.pay.paylist
{
    public class PayListUseCase : EmployeeGatewayFunctionUseCase<PayListRequest, PayListResponse>
    {
        private readonly EmployeeGateway employeeGateway;

        public PayListUseCase(
                TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway
                ) : base(transactionalRunner, employeeGateway)
        {
            this.employeeGateway = employeeGateway;
        }
        protected override PayListResponse ExecuteInTransaction(PayListRequest request)
        {
            return new PayListResponseCreator(employeeGateway).ToResponse(CreatePayChecks(request.payDate));
        }

        private List<PayCheck> CreatePayChecks(DateTime payDate)
        {
            return employeeGateway.findAll()
                .Where(e => e.isPayDate(payDate))
                .Select(e => e.createPayCheck(payDate))
                .ToList();
        }

    }

    public class PayListResponseCreator
    {
        private readonly EmployeeGateway employeeGateway;
        private PaymentTypeResponseFactory paymentTypeResponseFactory = new PaymentTypeResponseFactory();
        private PaymentMethodTypeResponseFactory paymentMethodTypeResponseFactory = new PaymentMethodTypeResponseFactory();
        public PayListResponseCreator(EmployeeGateway employeeGateway)
        {
            this.employeeGateway = employeeGateway;
        }
        public PayListResponse ToResponse(List<PayCheck> payChecks)
        {
            return new PayListResponse(
                payChecks.Select(payCheck => ToResponse(payCheck)).ToList<PayListResponseItem>()
            );
        }


        private PayListResponseItem ToResponse(PayCheck payCheck)
        {
            Employee employee = employeeGateway.findById(payCheck.getEmployeeId());

            PayListResponseItem payListResponseItem = new PayListResponseItem();
            payListResponseItem.employeeId = payCheck.getEmployeeId();
            payListResponseItem.grossAmount = payCheck.getGrossAmount();
            payListResponseItem.deductionsAmount = payCheck.getDeductionsAmount();
            payListResponseItem.netAmount = payCheck.getNetAmount();
            payListResponseItem.name = employee.getName();
            payListResponseItem.paymentTypeResponse = employee.getPaymentType().accept(paymentTypeResponseFactory);
            payListResponseItem.paymentMethodTypeResponse = employee.getPaymentMethod().Accept(paymentMethodTypeResponseFactory);
            return payListResponseItem;
        }

    }
}
