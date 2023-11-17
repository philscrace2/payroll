using System.Collections.Generic;

namespace PayrollInteractors.usecases.pay.paylist
{
    public class PayListUseCase : EmployeeGatewayFunctionUseCase<PayListRequest, PayListResponse>
    {


        public PayListUseCase(
                TransactionalRunner transactionalRunner,
                EmployeeGateway employeeGateway
                ) : base(transactionalRunner, employeeGateway)
        {

        }


        protected override PayListResponse executeInTransaction(PayListRequest request)
        {
            return new PayListResponseCreator().toResponse(createPayChecks(request.payDate));
        }

        private List<PayCheck> createPayChecks(LocalDate payDate)
        {
            return employeeGateway.findAll().stream()
                .filter(e->e.isPayDate(payDate))
                .map(e->e.createPayCheck(payDate))
                .collect(Collectors.toList());
        }

        private class PayListResponseCreator
        {
            private PaymentTypeResponseFactory paymentTypeResponseFactory = new PaymentTypeResponseFactory();
            private PaymentMethodTypeResponseFactory paymentMethodTypeResponseFactory = new PaymentMethodTypeResponseFactory();

            public PayListResponse toResponse(List<PayCheck> payChecks)
            {
                return new PayListResponse(payChecks.stream()
                        .map(payCheck->toResponse(payCheck))
                        .collect(Collectors.toList())
                        );
            }

            private PayListResponseItem toResponse(PayCheck payCheck)
            {
                Employee employee = employeeGateway.findById(payCheck.getEmployeeId());

                PayListResponseItem payListResponseItem = new PayListResponseItem();
                payListResponseItem.employeeId = payCheck.getEmployeeId();
                payListResponseItem.grossAmount = payCheck.getGrossAmount();
                payListResponseItem.deductionsAmount = payCheck.getDeductionsAmount();
                payListResponseItem.netAmount = payCheck.getNetAmount();
                payListResponseItem.name = employee.getName();
                payListResponseItem.paymentTypeResponse = employee.getPaymentType().accept(paymentTypeResponseFactory);
                payListResponseItem.paymentMethodTypeResponse = employee.getPaymentMethod().accept(paymentMethodTypeResponseFactory);
                return payListResponseItem;
            }

        }
    }
