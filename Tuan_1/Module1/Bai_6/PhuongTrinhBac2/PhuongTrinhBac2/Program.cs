using System;

namespace PhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            Console.WriteLine("***GIAI VA BIEN LUAN PHUONG TRINH BAC 2***");
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());
            PhuongTrinhBacHai ptbh = new PhuongTrinhBacHai(a, b, c);
            ptbh.Giai();
            Console.ReadLine();
        }
    }

    class PhuongTrinhBacHai
    {
        private int a;
        private int b;
        private int c;

        public PhuongTrinhBacHai(int hsa, int hsb, int hsc)
        {
            this.a = hsa;
            this.b = hsb;
            this.c = hsc;
        }

        public void Giai()
        {
            double d, x1, x2;
            d = Math.Pow(b, 2) - 4 * a * c;
            if (d == 0)
            {
                Console.WriteLine("Phuong trinh co Nghiem Kep x1 = x2 = " + Math.Round((-b / (2.0 * a)), 2));
            }
            else if (d > 0)
            {
                Console.WriteLine("Phuong trinh co 2 Nghiem phan biet");

                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);

                Console.Write("x1 = {0}\n", Math.Round(x1, 2));
                Console.Write("x2 = {0}\n", Math.Round(x2, 2));
            }
            else
                Console.WriteLine("Phuong trinh Vo Nghiem");
        }
    }
}
