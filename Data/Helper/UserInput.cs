using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Helper
{
    public static class UserInput
    {
        public static Employee FromConsoleEmployee()
        {
            Console.Write("Enter ID: ");
            int.TryParse(Console.ReadLine(), out int id);

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double.TryParse(Console.ReadLine(), out double salary);

            return new Employee(id, name, salary);
        }

        public static SinhVien FromConsoleStudent()
        {
            string[] formats = { "dd/MM/yyyy", "d/M/yyyy", "d/MM/yyyy", "dd/M/yyyy" };
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine("Enter BirthDay");
            DateTime.TryParseExact(Console.ReadLine(), formats, null, System.Globalization.DateTimeStyles.None, out DateTime birthday);
            Console.WriteLine("Enter GPA1: ");
            double.TryParse(Console.ReadLine(), out double gpa1);
            Console.WriteLine("Enter GPA2: ");
            double.TryParse(Console.ReadLine(), out double gpa2);
            return new SinhVien(id, name, age, birthday, gpa1, gpa2);

        }
    }
}
