using System;
using System.Threading;
using EventsAndDelegates;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1. Define a delegate
        // 2. Define an Event based on the delegate
        // 3. Raise the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                //VideoEncoded(this, new VideoEventArgs() { Video = video });
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Video has been encoded. Sending email...");
        }
    }



    // The code below would typically be in a separate file, such as Program.cs

    //var video = new Video() { title = "Video 1" };
    //var videoEncoder = new VideoEncoder(); // publisher
    //var mailService = new MailService(); // subscriber

    //videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

    //videoEncoder.Encode(video);




}