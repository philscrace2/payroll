using PayrollPorts.primaryAdminUseCase.response.employee;
using PayrollPorts.primaryAdminUseCase.response.employee.paymenttype;

namespace PayrollPorts.primaryAdminUseCase.response
{
    public class PayListResponse : Response
    {
        public List<PayListResponseItem> payListResponseItems;

        public PayListResponse(List<PayListResponseItem> payListResponseItems)
        {
            this.payListResponseItems = payListResponseItems;
        }

        public class PayListResponseItem
        {
            public int employeeId;
            public int grossAmount;
            public int deductionsAmount;
            public int netAmount;
            public String name;
            public PaymentTypeResponse paymentTypeResponse;
            public PaymentMethodTypeResponse paymentMethodTypeResponse;
        }

    }
}