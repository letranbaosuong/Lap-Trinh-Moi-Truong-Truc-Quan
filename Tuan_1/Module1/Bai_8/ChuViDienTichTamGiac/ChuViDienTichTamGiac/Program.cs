using System;

namespace ChuViDienTichTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("***CHU VI VA DIEN TICH TAM GIAC***");
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                if((a + b > c) && (a + c > b) && (b + c > a))
                {
                    TamGiac tg = new TamGiac(a, b, c);
                    Console.WriteLine("Chu Vi : "+ tg.ChuVi());
                    Console.WriteLine("Dien Tich : " + tg.DienTich(tg.ChuVi()));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Day khong phai la tam giac!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Canh phai lon hon 0!");
                Console.ReadLine();
            }
        }
    }

    class TamGiac
    {
        private int a;
        private int b;
        private int c;

        public TamGiac(int hsa, int hsb, int hsc)
        {
            this.a = hsa;
            this.b = hsb;
            this.c = hsc;
        }

        public int ChuVi()
        {
            return a + b + c;
        }

        public double DienTich(int cv)
        {

            double p = (double)cv / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
