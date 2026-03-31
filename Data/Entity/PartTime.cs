using Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
 public class PartTime :AEmployee
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public PartTime(int id, string name, string type,int hoursworked, decimal hourlyRate) : base(id, name, type)
        {
            HoursWorked = hoursworked;
            HourlyRate = hourlyRate;
        }
        public override decimal TinhLuong()
        {
   
            return HoursWorked * HourlyRate;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Type: {Type}, Salary: {TinhLuong()}");
        }

    }
}
