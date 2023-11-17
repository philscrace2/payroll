using PayrollEntities;
using PayrollEntities.paymenttype;
using PayrollPorts.primaryAdminUseCase.exception;
using PayrollPorts.primaryAdminUseCase.request.hourly;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.hourly
{
    public abstract class AbstractTimeCardUseCase<R> : EmployeeGatewayCommandUseCase<R> where R : AbstractTimeCardRequest
    {
        public AbstractTimeCardUseCase(
                TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway
                ) : base(transactionalRunner, employeeGateway)
        {

        }

        protected override void ExecuteInTransaction(R request)
        {
            Employee employee = employeeGateway.findById(request.employeeId);
            HourlyPaymentType hourlyPaymentType = castHourlyPaymentType(employee.getPaymentType());
            executeTimeCardOperation(request, hourlyPaymentType);
        }

        private HourlyPaymentType castHourlyPaymentType(PaymentType paymentType)
        {
            if (paymentType is HourlyPaymentType)
            {
                return (HourlyPaymentType)paymentType;
            }
            else
            {
                throw new NotHourlyPaymentTypeException();
            }
        }

        protected abstract void executeTimeCardOperation(R request, HourlyPaymentType hourlyPaymentType);

        public class NotHourlyPaymentTypeException : UseCaseException
        {
        }

    }


}