using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Price = 5, Title = "To kill a mocking bird"},
                new Book() {Price = 10, Title = "The Lean StartUp"},
                new Book() {Title = "1984", Price = 14.2M}
            };
        }

    }
}
