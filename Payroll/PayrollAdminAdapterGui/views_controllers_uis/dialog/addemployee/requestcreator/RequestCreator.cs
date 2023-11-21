using PayrollPorts.primaryAdminUseCase.request.addemployee;

namespace PayrollAdminAdapterGui.views_controllers_uis.dialog.addemployee.requestcreator
{
    public abstract class RequestCreator<I, O> where I : EmployeeViewModel where O : AddEmployeeRequest
    {
        public O toRequest(I model)
        {
            return fill(model, toSpecificRequest(model));
        }

        private O fill(I model, O request)
        {
            request.employeeId = model.employeeId;
            request.name = model.name;
            request.address = model.address;
            return request;
        }

        protected abstract O toSpecificRequest(I model);
    }

}