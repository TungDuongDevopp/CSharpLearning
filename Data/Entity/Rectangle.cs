

namespace Data.Entity
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double TinhChuVi()
        {
            return 2 * (Length + Width);
        }
        public override double TinhDienTich()
        {
            return Length * Width;
        }

    }
}
