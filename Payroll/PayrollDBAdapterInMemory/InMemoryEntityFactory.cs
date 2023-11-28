using PayrollDBAdapterInMemory.entity;
using PayrollEntities;
using PayrollEntities.affiliation;
using PayrollEntities.paymentmethod;
using PayrollEntities.paymentschedule;
using PayrollEntities.paymenttype;
using PayrollPorts.secondary.database;

namespace PayrollDBAdapterInMemory
{
    public class InMemoryEntityFactory : EntityFactory
    {

        public SalariedPaymentType salariedPaymentType(int monthlySalary)
        {
            return new SalariedPaymentTypeImpl(monthlySalary);
        }


        public HourlyPaymentType hourlyPaymentType(int hourlyWage)
        {
            return new HourlyPaymentTypeImpl(hourlyWage);
        }


        public CommissionedPaymentType commissionedPaymentType(int biWeeklyBaseSalary, double commissionRate)
        {
            return new CommissionedPaymentTypeImpl(biWeeklyBaseSalary, commissionRate);
        }


        public Employee employee()
        {
            return new EmployeeImpl();
        }


        public PaymentMethod paymasterPaymentMethod()
        {
            return new PaymasterPaymentMethodImpl();
        }


        public PaymentMethod directPaymentMethod(String accountNumber)
        {
            return new DirectPaymentMethodImpl(accountNumber);
        }

        public PaymentSchedule monthlyPaymentSchedule()
        {
            return new MonthlyPaymentScheduleImpl();
        }


        public WeeklyPaymentSchedule weeklyPaymentSchedule()
        {
            return new WeeklyPaymentScheduleImpl();
        }

        public BiWeeklyPaymentSchedule biWeeklyPaymentSchedule()
        {
            return new BiWeeklyPaymentScheduleImpl();
        }


        public TimeCard timeCard(DateTime date, int? workingHoursQty)
        {
            return new TimeCardImpl(date, workingHoursQty);
        }


        public SalesReceipt salesReceipt(DateTime date, int amount)
        {
            return new SalesReceiptImpl(date, amount);
        }


        public NoAffiliation noAffiliation()
        {
            return new NoAffiliationImpl();
        }


        public UnionMemberAffiliation unionMemberAffiliation(int? unionMemberId, int? weeklyDueAmount)
        {
            return new UnionMemberAffiliationImpl(unionMemberId, weeklyDueAmount);
        }


        public ServiceCharge serviceCharge(DateTime date, int amount)
        {
            return new ServiceChargeImpl(date, amount);
        }


    }
}