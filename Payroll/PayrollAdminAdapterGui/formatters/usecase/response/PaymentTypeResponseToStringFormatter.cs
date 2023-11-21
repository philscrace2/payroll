using PayrollPorts.primaryAdminUseCase.response.employee.paymenttype;

namespace PayrollAdminAdapterGui.formatters.usecase.response
{
    public class PaymentTypeResponseToStringFormatter : PaymentTypeResponseVisitor<String>
    {


        public String visit(HourlyPaymentTypeResponse paymentType)
        {
            return String.Format("%d / hour",
                    paymentType.hourlyWage
                    );
        }
        public String visit(SalariedPaymentTypeResponse paymentType)
        {
            return String.Format("%d / month",
                    paymentType.monthlySalary
                    );
        }


        public String visit(CommissionedPaymentTypeResponse paymentType)
        {
            return String.Format("%d / 2wk + %.0f%% sales",
                    paymentType.biWeeklyBaseSalary,
                    paymentType.commissionRate * 100
                    );
        }

    }


}