using PayrollEntities;
using PayrollInteractors.usecases.pay.fullfill.fullfillers;
using PayrollPorts.primaryAdminUseCase;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.primaryAdminUseCase.response;
using PayrollPorts.secondary.banktransfer;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.pay.fullfill
{
    public class PaymentFulfillUseCase : AbstractUseCase, IFunctionUseCase<PaymentFulfillRequest, PaymentFulfillResponse>
    {
        private EmployeeGateway employeeGateway;
        private PaymentFulfillerFactory paymentFulfillerFactory;

        public PaymentFulfillUseCase(
            EmployeeGateway employeeGateway,
            TransactionalRunner transactionalRunner,
            BankTransferPort bankTransferPort
            ) : base()
        {

            this.employeeGateway = employeeGateway;
            paymentFulfillerFactory = new PaymentFulfillerFactory(bankTransferPort, transactionalRunner);
        }
        public PaymentFulfillResponse Execute(PaymentFulfillRequest request)
        {
            CheckFirstExecution();
            return fullfill(CreatePayChecks(request.payDate));
        }

        private List<PayCheck> CreatePayChecks(DateTime payDate)
        {
            return employeeGateway.findAll()
                .Where(e => e.isPayDate(payDate))
                .Select(e => e.createPayCheck(payDate))
                .ToList();
        }


        private PaymentFulfillResponse fullfill(List<PayCheck> payChecks)
        {
            payChecks.ForEach(it => fullfill(it));
            return new PaymentFulfillResponse(payChecks.Count, CalcTotalNetAmount(payChecks));
        }

        private int? CalcTotalNetAmount(List<PayCheck> payChecks)
        {
            return payChecks.Sum(payCheck => payCheck.getNetAmount());
        }

        private void fullfill(PayCheck payCheck)
        {
            getEmployee(payCheck.getEmployeeId()).getPaymentMethod().Accept(paymentFulfillerFactory).fulfillPayment(payCheck);
        }

        private Employee getEmployee(int? employeeId)
        {
            return employeeGateway.findById(employeeId);
        }

    }
}

