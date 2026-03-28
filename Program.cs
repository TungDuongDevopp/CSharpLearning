


namespace CSharpLearning;

    internal class Program
    {
        static void Main(string[] args)
        {

        var data = new Student_Manager();
        var kq = data.DataFromFile();
        foreach (var item in kq)
        {
            Console.WriteLine(item.ToString());
        }
     

    }
       
    }

