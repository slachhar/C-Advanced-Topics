using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "LINQ can be used to group words and count them too";
            var strA = str.Split(' ');

            var result = from s in strA
                group s by s.Length
                into grp
                orderby grp.Key
                select new
                {
                    Length = grp.Key,
                    Count = grp.Count(),
                    words = grp
                };

            foreach (var r in result)
            {
                Console.WriteLine("Words of length:" + r.Length +", Count:"+ r.Count);
                foreach (var w in r.words)
                {
                    Console.WriteLine(w);
                }
            }

            Console.ReadLine();












            ////BookRepository rep = new BookRepository();
            ////var books = rep.GetBooks();
            //////LINQ Query Operator
            ////var cheap = from b in books
            ////    where b.Price < 10
            ////    orderby b.Title
            ////    select b.Title;

            //////LINQ Extension methods
            ////var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Title);
            ////foreach (var book in cheapBooks)
            ////{
            ////    Console.WriteLine(book);
            ////}
            ////Console.Read();
            ////Func<int, int> Square = number => number * number;
            ////Console.WriteLine(Square(10));
        }

        static bool CheaperThan10Dollar(Book book)
        {
            return book.Price < 10;
        }
    }
}
