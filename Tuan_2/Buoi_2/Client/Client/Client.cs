﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            /*Base b = new Derived("ok");
            b.Method1();
            Console.ReadLine();*/

            /*Base b = new MoreDerived();
            b.Method1();
            Console.ReadLine();*/

            Base b;
            Derived d;
            d = new Derived("test");
            b = d;
            b.Method2();
            d.Method2();
            Console.ReadLine();
        }
    }
}
