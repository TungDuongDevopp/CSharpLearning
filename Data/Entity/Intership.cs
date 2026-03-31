using Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Intership: AEmployee
    {
        public Intership(int id, string name,string type) : base(id, name,type)
        {
            
        }
        public override decimal TinhLuong()
        {
            return 5m;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Type: {Type}, Salary: {TinhLuong()}");
        }
    }
}
