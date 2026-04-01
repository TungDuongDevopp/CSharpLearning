using Data.Entity;
using Data.Interface;

namespace Data.Management
{
    public class EmployeeManager : IEmployee
    {
        private readonly List<Employee> _employees = new();

        public IReadOnlyList<Employee> GetAll()
        {
            return _employees;
        }

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            _employees.Add(employee);
        }

        public bool RemoveEmployee(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return false;

            _employees.Remove(emp);
            return true;
        }
    }
}