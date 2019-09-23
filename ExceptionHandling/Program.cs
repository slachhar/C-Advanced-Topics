using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var video = new YouTubeApi().GetVideos("Shefali");
                //using (StreamReader streamReader = new StreamReader(""))
                //{
                //    var video = 
                //}
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
