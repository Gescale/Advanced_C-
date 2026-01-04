//using System;
//using System.Threading;
//using EventsAndDelegates;

//namespace EventsAndDelegates
//{

//    public class VideoEventArgs : EventArgs
//    {
//        public Video video { get; set; }
//    }

//    public class VideoEncoder
//    {
//        // 1. Define a delegate
//        // 2. Define an Event based on the delegate
//        // 3. Raise the event

//        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
//        // or use the generic version provided by .NET
//        // The use of the generic version saves us from creating a delegate for every event

//        // EventHandler 
//        // EventHnadler<TEventArgs>
//        // public event EventHandler<VideoEventArgs> VideoEncoded; //example of generic version
//        // public event EventHandler VideoEncoded; // example of empty argument generic version

//        public event VideoEncodedEventHandler VideoEncoded;

//        public void Encode(Video video)
//        {
//            Console.WriteLine("Encoding video...");
//            Thread.Sleep(3000);

//            OnVideoEncoded(video);
//        }

//        protected virtual void OnVideoEncoded(Video video)
//        {
//            if (VideoEncoded != null)
//            {
//                VideoEncoded(this, new VideoEventArgs() { Video = video });
//                // VideoEncoded(this, EventArgs.Empty); // To pass an empty argument
//            }
//        }
//    }

//    public class MailService
//    {
//        public void OnVideoEncoded(object source, VideoEventArgs args)
//        {
//            Console.WriteLine("Video has been encoded. Sending email...");
//        }
//    }

//    public class MessageService
//    {
//        public void OnVideoEncoded(object source, VideoEventArgs args)
//        {
//            Console.WriteLine("Video has been encoded. Sending text message...");
//        }
//    }



//    // The code below would typically be in a separate file, such as Program.cs

//    //var video = new Video() { title = "Video 1" };
//    //var videoEncoder = new VideoEncoder(); // publisher
//    //var mailService = new MailService(); // subscriber
//    //var messageService = new MessageService(); // subscriber

//    //videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
//    //videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

//    //videoEncoder.Encode(video);




//}