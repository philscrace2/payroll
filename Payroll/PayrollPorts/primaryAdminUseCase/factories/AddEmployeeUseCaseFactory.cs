using PayrollPorts.primaryAdminUseCase.request.addemployee;

namespace PayrollPorts.primaryAdminUseCase.factories
{
    public interface AddEmployeeUseCaseFactory
    {
        CommandUseCase<AddSalariedEmployeeRequest> addSalariedEmployeeUseCase();
        CommandUseCase<AddHourlyEmployeeRequest> addHourlyEmployeeUseCase();
        CommandUseCase<AddCommissionedEmployeeRequest> addCommissionedEmployeeUseCase();
    }


}