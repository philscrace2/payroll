using PayrollEntities;
using PayrollEntities.affiliation;
using PayrollEntities.paymentmethod;
using PayrollEntities.paymentschedule;
using PayrollEntities.paymenttype;

namespace PayrollPorts.secondary.database
{
    public interface EntityFactory :
    EmployeeFactory,
    PaymentTypeFactory,
    PaymentMethodFactory,
    PaymentScheduleFactory,
    AffiliationFactory,
    TimeCardFactory,
    SalesReceiptFactory,
    ServiceChargeFactory

    { }
}
