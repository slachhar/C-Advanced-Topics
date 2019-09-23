using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Videos> GetVideos(string user)
        {
            try
            {
                throw new Exception("oops something went wrong");
            }
            catch (Exception e)
            {
                throw new YouTubeException("some error occured while fetching videos from youtube", e);
            }
            return new List<Videos>();
        }
    }
}
