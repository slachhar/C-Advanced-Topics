using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = new DateTime(2019,09,22);
            DateTime date2 = date.GetValueOrDefault();
            DateTime? date3 = date2;

            DateTime date4 = date ?? DateTime.Today;
            //Nullable<DateTime> date = null;

            //Console.WriteLine(date.GetValueOrDefault());
            //Console.WriteLine(date.HasValue);
            //Console.WriteLine(date.Value);
            //Console.ReadLine();
        }
    }
}
