using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost + "...");
            Console.ReadLine();
        }
    }

    public static class StringExtensions
    {
        public static string Shorten(this string str, int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException("number of words should be 0 or more");

            if (number == 0)
                return "";

            var stringArray = str.Split(' ');

            return string.Join(" ",stringArray.Take(5));
        }
    }
}
