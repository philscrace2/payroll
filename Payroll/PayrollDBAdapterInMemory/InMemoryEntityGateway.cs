using PayrollEntities;
using PayrollEntities.affiliation;
using PayrollPorts.secondary.database;
using static PayrollPorts.secondary.database.EmployeeGateway;

namespace PayrollDBAdapterInMemory
{
    public class InMemoryEntityGateway : EmployeeGateway
    {
        private Dictionary<int?, Employee> _employeesById = new Dictionary<int?, Employee>();

        public Employee findById(int? employeeId)
        {
            throw new NotImplementedException();
        }

        public int findEmployeeIdByUnionMemberId(int? unionMemberId)
        {
            throw new NotImplementedException();
        }

        public bool isEmployeeExistsByUnionMemberId(int? unionMemberId)
        {
            throw new NotImplementedException();
        }

        public void addNew(Employee employee)
        {
            _employeesById[employee.getId()] = employee;
        }

        public bool isExists(int? employeeId)
        {
            return _employeesById.ContainsKey(employeeId);
        }

        public Employee findById(int employeeId)
        {
            AssertNotNull(_employeesById.GetValueOrDefault(employeeId));
            return _employeesById[employeeId];
        }

        private void AssertNotNull(Employee employee)
        {
            if (employee == null)
                throw new NoSuchEmployeeException();
        }

        public IEnumerable<Employee> findAll()
        {
            return new List<Employee>(_employeesById.Values);
        }

        public void deleteById(int? employeeId)
        {
            _employeesById.Remove(employeeId);
        }

        // TODO: Test
        public bool IsEmployeeExistsByUnionMemberId(int unionMemberId)
        {
            return _employeesById.Values.Any(employee => employee.getAffiliation() is UnionMemberAffiliation affiliation && affiliation.getUnionMemberId() == unionMemberId);
        }

        // Wrong performance, but ok for now
        public int? FindEmployeeIdByUnionMemberId(int unionMemberId)
        {
            var employee = _employeesById.Values.FirstOrDefault(employee => employee.getAffiliation() is UnionMemberAffiliation affiliation && affiliation.getUnionMemberId() == unionMemberId);
            if (employee == null)
                throw new NoSuchEmployeeException();

            return employee.getId();
        }

        public void deleteAll()
        {
            _employeesById.Clear();
        }
    }

}