using PayrollAdminAdapterGui.formatters.common;
using PayrollAdminAdapterGui.formatters.usecase.response;
using PayrollPorts.primaryAdminUseCase.response;
using static PayrollAdminAdapterGui.formatters.common.SmartDateFormatter;
using static PayrollPorts.primaryAdminUseCase.response.EmployeeListResponse;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager.table
{
    public class EmployeeListPresenter
    {

        private EmployeeListResponse response;
        private PaymentTypeResponseToStringFormatter paymentTypeResponseToStringFormatter;
        private SmartDateFormatter smartDateFormatter;

        //@Inject
        public EmployeeListPresenter(
                DateTime currentDate,
                EmployeeListResponse response,
                PaymentTypeResponseToStringFormatter paymentTypeResponseToStringFormatter,
                SmartDateFormatterFactory smartDateFormatterFactory
                )
        {
            this.response = response;
            this.paymentTypeResponseToStringFormatter = paymentTypeResponseToStringFormatter;
            this.smartDateFormatter = smartDateFormatterFactory.of(currentDate);
        }

        public EmployeeListViewModel toViewModel()
        {
            return new EmployeeListViewModel(ToViewModel(response.employees));
        }

        private List<EmployeeViewItem> ToViewModel(List<EmployeeForEmployeeListResponse> employeeItems)
        {
            return employeeItems.Select(employeeItem => ToViewModel(employeeItem)).ToList<EmployeeViewItem>();
        }


        private EmployeeViewItem ToViewModel(EmployeeForEmployeeListResponse employeeItem)
        {
            EmployeeViewItem employeeViewItem = new EmployeeViewItem();
            employeeViewItem.id = employeeItem.id;
            employeeViewItem.name = employeeItem.name;
            employeeViewItem.address = employeeItem.address;
            employeeViewItem.waging = employeeItem.paymentTypeResponse.accept(paymentTypeResponseToStringFormatter);
            employeeViewItem.nextPayDay = smartDateFormatter.format(employeeItem.nextPayDay);
            return employeeViewItem;
        }

        public interface EmployeeListPresenterFactory
        {
            EmployeeListPresenter of(DateTime currentDate, EmployeeListResponse response);
        }

    }

}