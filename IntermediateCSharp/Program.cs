using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCSharp
{
    class Program 
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1989,09,18));
            Console.WriteLine(person.Age);
            Console.Read();
        }
    }
}
