using System;
using System.Collections.Generic;
using System.Linq;
using LambdaExpression;


// This code snippet demonstrates how to use LINQ (Language Integrated Query)
// To run the code in this file, make sure to call MyLinqLesson.Run() from the main file.
// MyLinqLesson.Run();


namespace LinqLesson
{
    public static class MyLinqLesson
    {
        public static void Run()
        {
            var booksTest = new BookRepository().GetBooks();

            // Using LINQ to filter books published after 2010
            var after2010 = booksTest.Where(b => b.Year > 2010);
            foreach (var book in after2010)
            {
                Console.WriteLine($"{book.Title} by {book.Author} ({book.Year})");
            }


            // - Objects in Memory, eg collections (LINQ to Objects)
            // - Database (LINQ to Entities)
            // - XML (LINQ to XML)
            // - Datasets (LINQ to Data Sets)

            var books = new BookRepository().GetBooks();

            // Count the number of books
            var bookCount = books.Count();

            // Calculate the average price of the books
            var averagePrice = books.Average(b => b.Price);

            // Calculate the total price of all books
            var totalPrice = books.Sum(b => b.Price);

            //Returns the maximum of something
            var maxPrice = books.Max(b => b.Price);

            //Returns the minimum of something
            var minPrice = books.Min(b => b.Price);

            // Returns the first book in the collection
            var firstBook = books.First();
            var firstBook2 = books.First(b => b.Year > 2015);
            var firstDefaultBook = books.FirstOrDefault(b => b.Year > 2025);

            // Returns the last book in the collection
            var lastBook = books.Last();
            var lastBook2 = books.Last(b => b.Year < 2000);
            var lasDefaultBook = books.LastOrDefault(b => b.Year < 1900);

            // Skip the first 5 books and take the next 4 books
            var pagedBooks = books.Skip(5).Take(4);

            // Finding a sinle book using a Lambda Expression
            // This method crashes when nothing or more than one book is found
            var singleBook1 = books.Single(b => b.Title == "Clean Code");
            Console.WriteLine();
            Console.WriteLine(singleBook1.Title + ", by " + singleBook1.Author);

            // The method returns null when no book is found
            // This gives us room to handle the null case
            var singleBook2 = books.SingleOrDefault(b => b.Title == "Head First Design Patterns");
            Console.WriteLine();
            Console.WriteLine(singleBook2.Title + ", by " + singleBook2.Author);

            // LINQ Query Operators with Lambda Expressions
            var affordableBooks = from b in books
                                  where b.Price < 10
                                  orderby b.Price
                                  select new { b.Title, b.Price };

            // LINQ Extension Methods with Lambda Expressions
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Price)
                .Select(b => new { b.Title, b.Price });

            // The LINQ cheapBooks Example using Lambda Expressions is
            // equivalent to the commented out code below it made using
            // traditional iteration.
            //var cheapBooks = books.Where(b => b.Price < 10);
            //var cheapBooks = new List<Book>();
            //foreach(var book in books)
            //{
            //    if(book.Price < 10)
            //    {
            //        cheapBooks.Add(book);
            //    }
            //}

            Console.WriteLine();
            Console.WriteLine("Extension");
            foreach (var book in cheapBooks)
            {
                Console.WriteLine($"{book.Title} - ${book.Price}");
            }

            Console.WriteLine();
            Console.WriteLine("Query");
            foreach (var book in affordableBooks)
            {
                Console.WriteLine($"{book.Title} - ${book.Price}");
            }
        }
    }
}