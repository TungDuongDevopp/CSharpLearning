using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Circle :Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double TinhChuVi()
        {
            return 2 * Math.PI * Radius;
        }
        public override double TinhDienTich()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }   

    }
}
