using PayrollPorts.primaryAdminUseCase.request.changemployee.affiliation;

namespace PayrollAdminAdapterGui.formatters.usecase.error
{
    public class UseCaseExceptionsFormatter
    {

        public String format(UnionMemberIdAlreadyExistsException e)
        {
            return String.Format("%s already owns this union member id!", e.ownerEmployeeName);
        }

    }


}