using PayrollEntities.paymenttype;

namespace PayrollPorts.primaryAdminUseCase.response.employee.paymenttype
{
    public abstract class PaymentTypeResponse
    {

        public abstract T accept<T>(PaymentTypeResponseVisitor<T> visitor);



        public class PaymentTypeResponseFactory : PaymentTypeVisitor<PaymentTypeResponse>
        {



            public PaymentTypeResponse visit(CommissionedPaymentType commissionedPaymentType)
            {
                return new CommissionedPaymentTypeResponse(commissionedPaymentType.getBiWeeklyBaseSalary(), commissionedPaymentType.getCommissionRate());
            }


            public PaymentTypeResponse visit(SalariedPaymentType salariedPaymentType)
            {
                return new SalariedPaymentTypeResponse(salariedPaymentType.getMonthlySalary());
            }


            public PaymentTypeResponse visit(HourlyPaymentType hourlyPaymentType)
            {
                return new HourlyPaymentTypeResponse(hourlyPaymentType.getHourlyWage());
            }

        }
    }

    public interface PaymentTypeResponseVisitor<T>
    {
        T visit(SalariedPaymentTypeResponse salariedPaymentTypeResponse);
        T visit(HourlyPaymentTypeResponse hourlyPaymentTypeResponse);
        T visit(CommissionedPaymentTypeResponse commissionedPaymentTypeResponse);
    }

}