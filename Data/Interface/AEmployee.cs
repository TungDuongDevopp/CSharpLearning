using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public abstract class AEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }

        public AEmployee(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
        public abstract decimal TinhLuong();
        public virtual void DisplayInfo() { }

    }
}
