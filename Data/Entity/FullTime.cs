using Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class FullTime: Employee
    {
        public FullTime(int id, string name, string type) : base(id, name, type)
        {

        }
        public override decimal TinhLuong()
        {
            return 15m;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Type: {Type}, Salary: {TinhLuong()}");
        }
    }
}
