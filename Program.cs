

using Data.Entity;


namespace CSharpLearning;

    internal class Program
    {
        
    static void Main(string[] args)
    {
       
        var rectangle = new Rectangle(5, 10);
        Console.WriteLine($"Chu vi hình chữ nhật: {rectangle.TinhChuVi()}");
        Console.WriteLine($"Diện tích hình chữ nhật: {rectangle.TinhDienTich()}");
        var circle = new Circle(7);
        Console.WriteLine($"Chu vi hình tròn: {circle.TinhChuVi()}");
        Console.WriteLine($"Diện tích hình tròn: {circle.TinhDienTich()}");
    }   
       
    }

