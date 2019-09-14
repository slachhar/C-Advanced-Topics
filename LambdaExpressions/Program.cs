using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            BookRepository rep = new BookRepository();
            var books = rep.GetBooks();
            var cheapBooks = books.FindAll(CheaperThan10Dollar);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
            Console.Read();
            ////Func<int, int> Square = number => number * number;
            ////Console.WriteLine(Square(10));
        }

        static bool CheaperThan10Dollar(Book book)
        {
            return book.Price < 10;
        }
    }
}
