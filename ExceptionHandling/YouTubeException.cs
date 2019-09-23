using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YouTubeException: Exception
    {
        public YouTubeException(string exceptionMessage, Exception innerException)
        :base(exceptionMessage, innerException)
        {
            
        }
    }
}
