﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["Key"] = "Shefali";
            Console.WriteLine(cookie["Key"]);
            Console.ReadLine();
        }
    }
}
