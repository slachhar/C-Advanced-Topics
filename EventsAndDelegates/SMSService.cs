using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class SmsService
    {
        public void OnVideoEncoded(object o, VideoEventArgs e)
        {
            Console.WriteLine("SMS Service: Sending an sms..." + e.video.Title);
        }
    }
}
