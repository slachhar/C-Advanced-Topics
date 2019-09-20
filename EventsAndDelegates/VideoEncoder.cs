using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise an event
        

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs(){video = video });
        }
    }

    public class VideoEventArgs
    {
        public Video video { get; set; }
    }
}
