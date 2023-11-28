using PayrollPorts.primaryAdminUseCase.exception;

namespace PayrollPorts.primaryAdminUseCase.request.changemployee.affiliation
{
    public class UnionMemberIdAlreadyExistsException : UseCaseException
    {

        public int? ownerEmployeeId;
        public String ownerEmployeeName;
        public UnionMemberIdAlreadyExistsException(int? ownerEmployeeId, String ownerEmployeeName)
        {
            this.ownerEmployeeId = ownerEmployeeId;
            this.ownerEmployeeName = ownerEmployeeName;
        }
    }


}