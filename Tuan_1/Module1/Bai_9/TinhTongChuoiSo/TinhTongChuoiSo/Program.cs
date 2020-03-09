using System;

namespace TinhTongChuoiSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n;
            Console.WriteLine("***TINH TONG DE QUY***");
            Console.Write("Nhap x : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap y : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S({0},{1}) = {2}", x, n, Math.Round(TinhTongDeQuy(x, n), 3));
            Console.ReadLine();
        }

        private static int GiaiThua(int n)
        {
            if (n == 1) return 1;
            else return n * GiaiThua(n - 1);
        }

        private static double LuyThua(double coSo, double soMu)
        {
            if (coSo == 1) return 1;
            else return Math.Pow(coSo, soMu);
        }

        private static double TinhTongDeQuy(int x, int n)
        {
            if (n == 1) return x;
            else return LuyThua(x, n) / GiaiThua(n) + TinhTongDeQuy(x, n - 1);
        }
    }
}
