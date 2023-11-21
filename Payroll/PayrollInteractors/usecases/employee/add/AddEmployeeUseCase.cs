using PayrollEntities;
using PayrollEntities.affiliation;
using PayrollEntities.paymentmethod;
using PayrollEntities.paymentschedule;
using PayrollEntities.paymenttype;
using PayrollInteractors.exception;
using PayrollPorts.primaryAdminUseCase.request.addemployee;
using PayrollPorts.primaryAdminUseCase.response.employee.add;
using PayrollPorts.secondary.database;

namespace PayrollInteractors.usecases.employee.add
{
    public abstract class AddEmployeeUseCase<R> : EmployeeGatewayCommandUseCase<R> where R : AddEmployeeRequest
    {

        private EmployeeFactory employeeFactory;
        private PaymentMethodFactory paymentMethodFactory;
        private AffiliationFactory affiliationFactory;
        private R request;

        public AddEmployeeUseCase(TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway,
                EmployeeFactory employeeFactory,
                PaymentMethodFactory paymentMethodFactory,
                AffiliationFactory affiliationFactory) : base(transactionalRunner, employeeGateway)
        {
            this.employeeFactory = employeeFactory;
            this.paymentMethodFactory = paymentMethodFactory;
            this.affiliationFactory = affiliationFactory;
        }

        protected override void ExecuteInTransaction(R request)
        {
            this.request = request;
            Validator v = new Validator(request, employeeGateway);

            Employee employee = employeeFactory.employee();

            setFields(employee, request);
            setDefaultFields(employee);
            setEmployeeTypeSpecificFields(employee, request);

            employeeGateway.addNew(employee);
        }


        private void setFields(Employee employee, R request)
        {
            employee.setId(request.employeeId);
            employee.setName(request.name);
            employee.setAddress(request.address);
        }

        private void setDefaultFields(Employee employee)
        {
            employee.setPaymentMethod(paymentMethodFactory.paymasterPaymentMethod());
            employee.setAffiliation(affiliationFactory.noAffiliation());
        }

        private void setEmployeeTypeSpecificFields(Employee employee, R request)
        {
            employee.setPaymentType(getPaymentType(request));
            employee.setPaymentSchedule(getPaymentSchedule());
        }

        protected abstract PaymentType getPaymentType(R request);
        protected abstract PaymentSchedule getPaymentSchedule();
    }

    public class Validator : MultipleErrorsUseCaseExceptionThrower<IAddEmployeeError>
    {
        private readonly AddEmployeeRequest request;
        private readonly EmployeeGateway employeeGateway;

        public Validator(AddEmployeeRequest request, EmployeeGateway employeeGateway)
        {
            this.request = request;
            this.employeeGateway = employeeGateway;
        }

        protected override void addErrors()
        {
            checkIdExists();
            checkNameExists();
        }

        private void checkIdExists()
        {
            if (employeeGateway.isExists(request.employeeId))
            {
                Employee employee = employeeGateway.findById(request.employeeId);
                addError(new IdAlreadyExistsValidationError(employee.getName()));
            }
        }

        private void checkNameExists()
        {
            // TODO Auto-generated method stub
        }

    }
}


