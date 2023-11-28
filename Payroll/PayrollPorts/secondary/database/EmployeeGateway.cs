using PayrollEntities;

namespace PayrollPorts.secondary.database
{
    public interface EmployeeGateway
    {

        bool isExists(int? employeeId);

        /**
         * @throws NoSuchEmployeeException
         */
        PayrollEntities.Employee findById(int? employeeId);

        /**
         * @throws NoSuchEmployeeException
         */
        int findEmployeeIdByUnionMemberId(int? unionMemberId);

        bool isEmployeeExistsByUnionMemberId(int? unionMemberId);

        IEnumerable<Employee> findAll();

        void addNew(Employee employee);

        void deleteById(int? employeeId);

        void deleteAll();

        public class NoSuchEmployeeException : Exception { }

    }
}
