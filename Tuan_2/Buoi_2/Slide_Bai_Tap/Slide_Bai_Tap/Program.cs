using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide_Bai_Tap
{
    class Program
    {
        enum Days
        {
            Sat,
            Sun,
            Mon,
            Tue,
            Web,
            Thu,
            Fri
        }
        static void Main(string[] args)
        {
            // Slide 8 - LTTQ2.ppt
            Console.WriteLine("___Cac Thanh Phan Trong Lop___");
            KhachHang1.mTenKH = "Suong";
            KhachHang1.In();
            Console.WriteLine("------------------------------");

            // Slide 9 - LTTQ2.ppt
            KhachHang2 objKH = new KhachHang2();
            objKH.In();
            objKH.mTenKH = "ABC";
            Console.WriteLine("--------------------");

            // Slide 4 - LTTQ4.ppt
            Console.WriteLine("___Overloading Methods___");
            Point objP1 = new Point(1, 1);
            Point objP2 = new Point(2, 2);
            Point objResult = new Point();
            objResult = objP1 + objP2;
            Console.WriteLine("The result is m_x = {0} and m_y = {1}", objResult.m_x, objResult.m_y);
            Console.WriteLine("-------------------------");

            // Slide 7 - LTTQ4.ppt
            Console.WriteLine("_______Struct_______");
            PointStruct p1 = new PointStruct();
            PointStruct p2 = new PointStruct(10, 10);
            Console.Write("Point 1: ");
            Console.WriteLine("x = {0}, y = {1}", p1.x, p1.y);
            Console.Write("Point 2: ");
            Console.WriteLine("x = {0}, y = {1}", p2.x, p2.y);
            Console.WriteLine("Call Add Method: {0}", p2.Add());
            Console.WriteLine("--------------------");

            // Slide 7 - LTTQ4.ppt
            Console.WriteLine("_______Enumrator_______");
            int x = (int)Days.Sun;
            int y = (int)Days.Fri;
            Console.WriteLine("Sun = {0} : Value : {1}", x, Days.Sun);
            Console.WriteLine("Fri = {0} : Value : {1}", y, Days.Fri);
            Console.WriteLine("--------------------");

            // Slide 17 - LTTQ4.ppt
            Console.WriteLine("_______Properties_______");
            Rectangle objRectangle = new Rectangle();
            objRectangle.Lenght = 3;
            objRectangle.Width = 4;
            objRectangle.CallArea();
            Console.WriteLine("{0}", objRectangle.Area);
            Console.WriteLine("--------------------");

            // Slide 20 - LTTQ4.ppt
            Console.WriteLine("_______Indexer_______");
            IndexerClass b = new IndexerClass();
            b[3] = 256;
            b[5] = 1024;
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Element # {0} = {1}", i, b[i]);
            }
            Console.WriteLine("--------------------");

            // Slide 6 - LTTQ5.ppt
            Console.WriteLine("_______Ke Thua_______");
            MicrosoftSoftware objMS = new MicrosoftSoftware();
            IBMSoftware objBM1 = new IBMSoftware(50);
            IBMSoftware objBM2 = new IBMSoftware("test", 75);
            Console.WriteLine("--------------------");

            // Slide 10 - LTTQ5.ppt
            Console.WriteLine("_______Overriding Method_______");
            Animal a1 = new Animal();
            a1.Talk();
            Dog d1 = new Dog();
            d1.Talk();
            Console.WriteLine("-------------------------------");

            // Slide 10 - LTTQ5.ppt
            Console.WriteLine("_______Da Hinh - Polymorphism_______");
            Animal objA = new Animal();
            Dog objD = new Dog();
            objA = objD;
            objA.Talk1();
            Console.WriteLine("-------------------------------");

            // Slide 17 - LTTQ5.ppt
            Console.WriteLine("_______Abstract Class_______");
            RectangleKeThua objRec = new RectangleKeThua();
            objRec.CalculateArea();
            objRec.CalculateCircumference();
            Console.WriteLine("------------------------------------");

            // Slide 20 - LTTQ5.ppt
            Console.WriteLine("_______Interface_______");
            BaseInterface obj = new BaseInterface();
            obj.Print();
            // Gọi phương thức Print() bằng  interface  ITest
            ITest ib = (ITest)obj;
            ib.Print();
            // Gọi phuong thức Print() bằng cách ép kiểu Interface ITest về lớp Base
            BaseInterface ojB = (BaseInterface)ib;
            ojB.Print();
            Console.WriteLine("-----------------------");

            Console.ReadLine();
        }
    }
}
