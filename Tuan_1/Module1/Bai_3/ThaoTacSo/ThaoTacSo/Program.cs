using System;

namespace ThaoTacSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSo1, nSo2, nTong = 0;
            Console.Clear();
            Console.Write("{0}", "Nhap so thu nhat: ");
            // read first number from user
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            // read second number from user
            nSo2 = Convert.ToInt32(Console.ReadLine());
            nTong = nSo1 + nSo2;
            Console.WriteLine("Tong cua " + nSo1 + " Va " + nSo2 + " La " + nTong);
            Console.ReadLine();

            // Mo rong
            int nHieu = 0, nTich = 0;
            float nThuong = 0;

            // Tru
            Console.Clear();
            Console.Write("{0}", "Nhap so thu nhat: ");
            // read first number from user
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            // read second number from user
            nSo2 = Convert.ToInt32(Console.ReadLine());
            nHieu = Tru(nSo1, nSo2);
            Console.WriteLine("Hieu cua " + nSo1 + " Va " + nSo2 + " La " + nHieu);
            Console.ReadLine();

            // Nhan
            Console.Clear();
            Console.Write("{0}", "Nhap so thu nhat: ");
            // read first number from user
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            // read second number from user
            nSo2 = Convert.ToInt32(Console.ReadLine());
            nTich = Nhan(nSo1, nSo2);
            Console.WriteLine("Tich cua " + nSo1 + " Va " + nSo2 + " La " + nTich);
            Console.ReadLine();

            // Chia
            Console.Clear();
            Console.Write("{0}", "Nhap so thu nhat: ");
            // read first number from user
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            // read second number from user
            nSo2 = Convert.ToInt32(Console.ReadLine());
            nThuong = Chia(nSo1, nSo2);
            Console.WriteLine("Thuong cua " + nSo1 + " Va " + nSo2 + " La " + nThuong);
            Console.ReadLine();
        }

        public static int Cong(int so1, int so2)
        {
            return so1 + so2;
        }

        public static int Tru(int so1, int so2)
        {
            return so1 - so2;
        }

        public static int Nhan(int so1, int so2)
        {
            return so1 * so2;
        }

        public static float Chia(int so1, int so2)
        {
            return (float)so1 / so2;
        }
    }
}
