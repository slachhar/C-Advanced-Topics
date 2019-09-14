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
            Action<Photo> filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += RedEyeFilter;
            processor.Process("", filterHandler);
            Console.ReadLine();
        }

        public static void RedEyeFilter(Photo photo)
        {
            Console.WriteLine();
        }
    }
}
