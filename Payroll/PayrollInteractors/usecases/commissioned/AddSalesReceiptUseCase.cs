using PayrollEntities;
using PayrollEntities.paymenttype;
using PayrollPorts.primaryAdminUseCase.exception;
using PayrollPorts.primaryAdminUseCase.request;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.commisioned
{
    public class AddSalesReceiptUseCase : EmployeeGatewayCommandUseCase<AddSalesReceiptRequest>
    {


        private SalesReceiptFactory salesReceiptFactory;

        public AddSalesReceiptUseCase(
                TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway,
                SalesReceiptFactory salesReceiptFactory
                ) : base(transactionalRunner, employeeGateway)
        {

            this.salesReceiptFactory = salesReceiptFactory;
        }


        protected override void ExecuteInTransaction(AddSalesReceiptRequest request)
        {
            Employee employee = employeeGateway.findById(request.employeeId);

            castCommissionedPaymentType(employee.getPaymentType())
                .addSalesReceipt(createSalesReceipt(request));
        }

        private CommissionedPaymentType castCommissionedPaymentType(PaymentType paymentType)
        {
            if (paymentType is CommissionedPaymentType)
            {
                return (CommissionedPaymentType)paymentType;
            }
            else
            {
                throw new NotCommissionedPaymentTypeException();
            }
        }

        private SalesReceipt createSalesReceipt(AddSalesReceiptRequest request)
        {
            return salesReceiptFactory.salesReceipt(request.date, request.amount);
        }

        public class NotCommissionedPaymentTypeException : UseCaseException
        {
        }

    }



}