using System;

namespace PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int so1 = 0, so2 = 0;
            PhuongTrinhBacNhat ptbn = new PhuongTrinhBacNhat();
            Console.WriteLine("***GIAI VA BIEN LUAN PHUONG TRINH BAC 1***");
            Console.Write("Nhap a: ");
            so1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            so2 = Convert.ToInt32(Console.ReadLine());
            ptbn.NhapHeSo(so1, so2);
            ptbn.Giai();
            Console.ReadLine();
        }
    }

    class PhuongTrinhBacNhat
    {
        private int a = 0;
        private int b = 0;
        public void NhapHeSo(int hsa, int hsb)
        {
            this.a = hsa;
            this.b = hsb;
        }
        public void Giai()
        {
            if (this.a == 0)
            {
                if (this.b == 0)
                {
                    Console.WriteLine("Phuong trinh Vo So Nghiem.");
                }
                else
                {
                    Console.WriteLine("Phuong trinh Vo Nghiem.");
                }
            }
            else
            {
                if (this.b == 0)
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem x = 0");
                }
                else
                {
                    float x = (float)-b / a;
                    Console.WriteLine("Phuong trinh co 1 nghiem x = " + Math.Round(x, 1));
                }
            }
        }
    }
}
