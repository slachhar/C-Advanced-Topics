using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video(){Title = "Lambhorgini"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var smsService = new SmsService(); //subscriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;
            videoEncoder.Encode(video);

            Console.ReadLine();
        }
    }
}
