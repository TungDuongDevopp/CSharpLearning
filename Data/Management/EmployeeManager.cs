using Data.Entity;

namespace Data.Management
{
    public class EmployeeManager
    {
        private readonly List<Employee> _employees = new();

        public IReadOnlyList<Employee> GetAll()
        {
            return _employees;
        }

        public void Add(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            _employees.Add(employee);
        }

        public bool Remove(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return false;

            _employees.Remove(emp);
            return true;
        }
    }
}