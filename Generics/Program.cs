
using System;
using System.Runtime.InteropServices;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
			Console.WriteLine("Has Value ?" + number.HasValue);
			Console.WriteLine("Value:" + number.GetValueorDefault());
			Console.ReadLine();
        }
    }
}
