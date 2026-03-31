using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Helper
{
    public static class EmployeeInput
    {
        public static Employee FromConsole()
        {
            Console.Write("Enter ID: ");
            int.TryParse(Console.ReadLine(), out int id);

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double.TryParse(Console.ReadLine(), out double salary);

            return new Employee(id, name, salary);
        }
    }
}
