using System.Net.WebSockets;

namespace CSharpLearning;

    internal class Program
    {
        static void Main(string[] args)
        {
        var sv1 = new SinhVien("2221050152","Duong",22,9.1,8.6);
        var kq = sv1.DanhGiaHocLuc(sv1);
        Console.WriteLine(kq);
      
        }
       
}

