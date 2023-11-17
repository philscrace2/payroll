using PayrollEntities.paymenttype;
using PayrollPorts.primaryAdminUseCase.request.hourly;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.hourly
{
    public class UpdateTimeCardUseCase : AbstractTimeCardUseCase<UpdateTimeCardRequest>
    {


        public UpdateTimeCardUseCase(
                TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway
                ) : base(transactionalRunner, employeeGateway)
        {

        }


        protected override void executeTimeCardOperation(UpdateTimeCardRequest request, HourlyPaymentType hourlyPaymentType)
        {
            var timeCard = hourlyPaymentType.getTimeCard(request.date);
            if (timeCard == null)
            {
                throw new TimeCardNotExistsException();
            }

            updateTimeCard(timeCard, request);
        }


        private void updateTimeCard(TimeCard timeCard, UpdateTimeCardRequest request)
        {
            timeCard.setWorkingHourQty(request.workingHoursQty);
        }

    }

}