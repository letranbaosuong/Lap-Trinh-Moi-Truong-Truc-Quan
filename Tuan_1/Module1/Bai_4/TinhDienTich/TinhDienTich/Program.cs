using System;

namespace TinhDienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            int dai, rong, chuVi = 0, dienTich = 0;
            Console.WriteLine("***************Tinh chu vi & Dien tich***************");
            Console.Write("Nhap vao chieu Dai : ");
            dai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao chieu Rong : ");
            rong = Convert.ToInt32(Console.ReadLine());
            chuVi = (dai + rong) * 2;
            dienTich = dai * rong;
            Console.WriteLine("Chu vi = " + chuVi);
            Console.WriteLine("Dien tich = " + dienTich);
            Console.ReadLine();
        }
    }
}
