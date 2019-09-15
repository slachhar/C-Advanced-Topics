using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationOfEvents nOE = new NotificationOfEvents();
            Subscriber1 subs1 = new Subscriber1();
            Subscriber2 subs2 = new Subscriber2();
            nOE.notifyDelegate += subs1.OnNotified;
            nOE.notifyDelegate += subs2.OnNotified;
            nOE.NotifyMethod(1);
            Console.ReadLine();
        }
    }
}
