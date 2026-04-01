

using Data.Entity;
using Data.Helper;
using Data.Management;


namespace CSharpLearning;

    internal class Program
    {
        
    static void Main(string[] args)
    {
        var student = new Student_Manager();

        Console.WriteLine("1. Add from input");
        Console.WriteLine("2. Add from file");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            var emp = UserInput.FromConsoleStudent();
            student.AddStudent(emp);
        }
        else if (choice == 2)
        {
            var reader = new UserExcelReader();
            var list = reader.ReadStudentList();

            foreach (var emp in list)
            {
                student.AddStudent(emp);
            }
        }

        // Print
        foreach (var emp in student.GetAll())
        {
            Console.WriteLine(emp);
        }

    }   
       
    }

