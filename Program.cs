

using Data.MyColections;

namespace CSharpLearning;

    internal class Program
    {
        
    static void Main(string[] args)
        {
        var stack = new MyStack<SinhVien>();

        stack.Push(new SinhVien("SV001", "Nguyen Van A", 20, new DateTime(2004,08,07), 3.5, 3.8));
        stack.Push(new SinhVien("SV002", "Nguyen Van B", 21, new DateTime(2003,11,07), 3.1, 3.2));
        stack.Push(new SinhVien("SV003", "Trần Thị C", 22, new DateTime(1992 , 11 , 22), 2.7, 3.5));
        Console.WriteLine("Stack ban đầu là: ");
        stack.PrintStack();
        var item= stack.Pop();
        Console.WriteLine($"Phần tử bị lấy ra là:{item} ");
        Console.WriteLine("Stack lúc sau là là: ");
        stack.PrintStack();


    }   
       
    }

