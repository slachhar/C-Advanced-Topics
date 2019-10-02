using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string Key]
        {
            get { return _dictionary[Key]; }
            set { _dictionary[Key] = value; }
        }

    }
}
