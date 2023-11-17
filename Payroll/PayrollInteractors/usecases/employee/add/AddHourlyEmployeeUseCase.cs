using PayrollEntities;
using PayrollEntities.affiliation;
using PayrollEntities.paymentmethod;
using PayrollEntities.paymentschedule;
using PayrollEntities.paymenttype;
using PayrollPorts.primaryAdminUseCase.request.addemployee;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.employee.add
{
    public class AddHourlyEmployeeUseCase : AddEmployeeUseCase<AddHourlyEmployeeRequest>
    {

        private PaymentTypeFactory paymentTypeFactory;
        private PaymentScheduleFactory paymentScheduleFactory;

        public AddHourlyEmployeeUseCase(
                TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway,
                EmployeeFactory employeeFactory,
                PaymentMethodFactory paymentMethodFactory,
                AffiliationFactory affiliationFactory,
                PaymentTypeFactory paymentTypeFactory,
                PaymentScheduleFactory paymentScheduleFactory
                ) : base(transactionalRunner, employeeGateway, employeeFactory, paymentMethodFactory, affiliationFactory)
        {


            this.paymentTypeFactory = paymentTypeFactory;
            this.paymentScheduleFactory = paymentScheduleFactory;
        }


        protected override PaymentType getPaymentType(AddHourlyEmployeeRequest request)
        {
            return paymentTypeFactory.hourlyPaymentType(request.hourlyWage);
        }


        protected override PaymentSchedule getPaymentSchedule()
        {
            return paymentScheduleFactory.weeklyPaymentSchedule();
        }
    }


}

