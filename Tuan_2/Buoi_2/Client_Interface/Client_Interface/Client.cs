using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Interface
{
    class Client
    {
        private delegate void NotifyMe(string s1);
        static void Main(string[] args)
        {
            /*IHuman h;
            Theodore t;
            h = new Theodore();
            t = (Theodore)h;
            t.Speak("I like public implementations!");
            h.Name = "Teddy";
            h.Speak("I like VB!");
            Console.ReadLine();*/

            NotifyMe d = new NotifyMe(Listener.GetNotifiedAgain);
            InvokeDelegate(d);
            Listener lsnr = new Listener();
            NotifyMe d2 = new NotifyMe(lsnr.GetNotified);
            InvokeDelegate(d2);
            Console.ReadLine();
        }
        static void InvokeDelegate(NotifyMe d)
        {
            d("You are late paying your bills!");
        }
    }
}
