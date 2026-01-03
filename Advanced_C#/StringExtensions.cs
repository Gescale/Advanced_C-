using System;
using System.Linq;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        // C# 14.0 introduces a new extension method feature
        public static string ToTitleCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            var words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            return string.Join(' ', words);
        }

        public static string Shorten(this string str, int numberOfWords)
        {
            if(numberOfWords < 0)
                throw new ArgumentOutOfRangeException(nameof(numberOfWords), "Number of words must be non-negative.");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length < numberOfWords)
                return str;

            return string.Join(' ', words.Take(numberOfWords)) + "...";
        }
    }


    //Example usage : 
    // To be placed in Program.cs or any other file

    //var example = "this is an example string for extension methods in C#";
   
    //var titleCased = example.ToTitleCase();
    //var shortened = example.Shorten(5);

    //Console.WriteLine(titleCased);
    //Console.WriteLine(shortened);
}