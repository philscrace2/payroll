using PayrollPorts.primaryAdminUseCase.response;

namespace PayrollAdminAdapterGui.views_controllers_uis.mainframe.mainpanel.employeemanager
{
    public interface ObservableSelectedEmployee : Observable<EmployeeForEmployeeListResponse>
    {
        void addChangeListener(Action value);
    }

}