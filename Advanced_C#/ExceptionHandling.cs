using System;

namespace ExceptionHandlingNS
{
    // You can create a custom exception by deriving from Exception class
    // We can do more but this is the most basic thing we can do with the base class
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    public static class ExceptionHandling
    {
        public static void Run()
        {

            // -----------------------------------------------------------------------------------------------------------


            //// This is the best way to open streams because the disposition is managed by the using block
            //try
            //{
            //    // The using block doesnt require the finally block to dispose the stream because it manages 
            //    using(var streamReader = new StreamReader(@"C:\Users\gesca\Desktop\file.txt"))
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }
            //}

            //catch(Exception  ex) {
            //{
            //        Console.WriteLine("Normal Exception: " + ex.ToString());
            //        // The normal exception that is thrown or generated from the try block will be automatically caught by the Exception in the catch block
            //        // We can dig dipper and find the innerException, to find the root origin of the exception
            //        throw new YouTubeException("Could not fetch the youtube videos from Youtube.", ex); // This is the way the Youtube class would be used
            //}


            // -----------------------------------------------------------------------------------------------------------

            //// This is the other way of doing it
            //Console.WriteLine("Working : ExceptionHandling");
            //var streamReader = new StreamReader(@"C:\Users\gesca\Desktop\file.txt");

            //try
            //{
            //    // Try getting the contents of the file
            //    var content = streamReader.ReadToEnd();
            //    throw new Exception("Ooops!");
            //}

            //// Te order of exception matters a lot Exception should be the second last before finally or last
            //catch(DivideByZeroException ex)
            //{
            //    // Should run if the number is divided by zero
            //    Console.WriteLine("DivideByZeroException.");
            //}

            //catch(ArithmeticException)
            //{
            //    // Some other exception
            //    Console.WriteLine("ArithmeticException");
            //}

            //catch (Exception ex)
            //{
            //    // Taking the error to output it as a string
            //    Console.WriteLine("Normal Exception: " + ex.ToString());
            //}

            //finally
            //{
            //    //This block runs regardless of whether there is an exception or not.
            //    // We can use this block to dispose all the open streams
            //    Console.WriteLine("Finally block running");
            //    if(streamReader != null)
            //        streamReader.Dispose();
            //}

// -----------------------------------------------------------------------------------------------------------

        }
    }
}