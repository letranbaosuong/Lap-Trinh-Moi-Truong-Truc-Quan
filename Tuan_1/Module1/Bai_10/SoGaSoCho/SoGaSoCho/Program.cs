using System;

namespace SoGaSoCho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***GIAI BAI TAP SO GA, SO CHO***");
            double a1, a2, b1, b2, c1, c2, d, dx, dy;
            Console.Write("Nhap a1 : ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b1 : ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c1 : ");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap a2 : ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b2 : ");
            b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c2 : ");
            c2 = Convert.ToInt32(Console.ReadLine());
            d = a1 * b2 - a2 * b1;
            dx = c1 * b2 - c2 * b1;
            dy = a1 * c2 - a2 * c1;
            Console.WriteLine("x = " + dx / d);
            Console.WriteLine("y = " + dy / d);
            Console.ReadLine();
        }
    }
}
