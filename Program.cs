namespace Buoi1;

    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static double TinhToan()
        {
            double a, b;
            Console.Write("Mời bạn nhập số a: ");
            bool kq1 = double.TryParse(Console.ReadLine(), out a);

            Console.Write("Mời bạn nhập số b: ");
            bool kq2 = double.TryParse(Console.ReadLine(), out b);

            // Kiểm tra nếu nhập liệu thành công
            if (kq1 && kq2)
            {
                Console.Write("Mời nhập phép tính (+, -, *, /, %): ");
                string pheptoan = Console.ReadLine();

                return pheptoan switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    "/" => b != 0 ? a / b : double.NaN, // Tránh chia cho 0
                    "%" => a % b,
                    _ => double.NaN // Trả về NaN nếu phép tính không hợp lệ
                };
            }

            return double.NaN; // Trả về NaN nếu nhập số không hợp lệ
        }

        static int TinhNgay(int number)
        => number switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            2 => 28,
            4 or 6 or 9 or 11 => 30,
            _ => throw new ArgumentException()

        };

        static long TinhGiaiThua(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * TinhGiaiThua(n - 1);
        }

        static bool IsPrime(int n)
        {
            if (n <= 1) return false;


            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
               
            }
            return true;
        }
        static void Prime(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (IsPrime(i)) Console.Write(i + " ");
            }
        }
    }

