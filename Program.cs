

using Data.Entity;
using Data.Helper;
using Data.Management;


namespace CSharpLearning;

    internal class Program
    {
        
    static void Main(string[] args)
    {
        var manager = new EmployeeManager();

        Console.WriteLine("1. Add from input");
        Console.WriteLine("2. Add from file");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            var emp = EmployeeInput.FromConsole();
            manager.Add(emp);
        }
        else if (choice == 2)
        {
            var reader = new EmployeeExcelReader();
            var list = reader.Read();

            foreach (var emp in list)
            {
                manager.Add(emp);
            }
        }

        // Print
        foreach (var emp in manager.GetAll())
        {
            Console.WriteLine(emp);
        }

    }   
       
    }

