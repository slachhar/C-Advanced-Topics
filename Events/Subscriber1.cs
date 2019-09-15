using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Subscriber1
    {
        public void OnNotified(int i)
        {
            Console.WriteLine("I am subscriber1 " + i + "and I am notified");
        }
    }
}
