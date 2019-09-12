using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericList<T> where T : IComparable, new()
    {
        public void Add(T name)
        {
            throw new NotImplementedException();
        }

        public void DoSomething()
        {
			var obj = new T();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
