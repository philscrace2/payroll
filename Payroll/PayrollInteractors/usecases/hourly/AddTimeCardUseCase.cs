using PayrollEntities.paymenttype;
using PayrollPorts.primaryAdminUseCase.request.hourly;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.hourly
{
    public class AddTimeCardUseCase : AbstractTimeCardUseCase<AddTimeCardRequest>
    {
        private TimeCardFactory timeCardFactory;

        public AddTimeCardUseCase(
                TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway,
                TimeCardFactory timeCardFactory
                ) : base(transactionalRunner, employeeGateway)
        {

            this.timeCardFactory = timeCardFactory;
        }


        protected override void executeTimeCardOperation(AddTimeCardRequest request, HourlyPaymentType hourlyPaymentType)
        {
            ValidateTimeCardNotExists(request, hourlyPaymentType);
            hourlyPaymentType.addTimeCard(createTimeCard(request));
        }

        private void ValidateTimeCardNotExists(AddTimeCardRequest request, HourlyPaymentType hourlyPaymentType)
        {
            var timeCard = hourlyPaymentType.getTimeCard(request.date);
            if (timeCard != null)
            {
                throw new TimeCardAlreadyExistsException();
            }
        }

        private TimeCard createTimeCard(AddTimeCardRequest request)
        {
            return timeCardFactory.timeCard(request.date, request.workingHoursQty);
        }
    }

}