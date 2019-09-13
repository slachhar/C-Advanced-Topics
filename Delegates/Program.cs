using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filter = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            processor.Process("", filterHandler);
            Console.ReadLine();
        }
    }
}
