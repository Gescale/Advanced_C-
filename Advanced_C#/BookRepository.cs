//namespace LambdaExpression
//{
//    public class Book
//    {
//        public string Title { get; set; }
//        public string Author { get; set; }
//        public int Year { get; set; }
//        public float Price { get; set; }
//    }

//    public class BookRepository
//    {
//        public List<Book> GetBooks()
//        {
//            return new List<Book>
//            {
//                new Book { Title = "C# in Depth", Author = "Jon Skeet", Year = 2019, Price = 20.5f },
//                new Book { Title = "Pro ASP.NET Core", Author = "Adam Freeman", Year = 2020, Price = 16.4f },
//                new Book { Title = "Clean Code", Author = "Robert C. Martin", Year = 2008, Price = 10.2f },
//                new Book { Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Year = 1999, Price = 6.2f },
//                new Book { Title = "Refectoring UI", Author = "Lindsey Holm", Year = 2015, Price = 2.9f },
//                new Book { Title = "Design Patterns", Author = "Erich Gamma", Year = 1994, Price = 5.5f },
//                new Book { Title = "Introduction to Algorithms", Author = "Thomas H. Cormen", Year = 2009, Price = 15.0f },
//                new Book { Title = "Effective C#", Author = "Bill Wagner", Year = 2017, Price = 12.3f },
//                new Book { Title = "Head First Design Patterns", Author = "Eric Freeman", Year = 2004, Price = 8.7f },
//                new Book { Title = "Code Complete", Author = "Steve McConnell", Year = 2004, Price = 11.1f },
//                new Book { Title = "The Clean Coder", Author = "Robert C. Martin", Year = 2011, Price = 9.8f },
//                new Book { Title = "Working Effectively with Legacy Code", Author = "Michael Feathers", Year = 2004, Price = 7.6f },
//                new Book { Title = "Agile Software Development", Author = "Alistair Cockburn", Year = 2001, Price = 4.3f },
//                new Book { Title = "Domain-Driven Design", Author = "Eric Evans", Year = 2003, Price = 13.5f },
//                new Book { Title = "Patterns of Enterprise Application Architecture", Author = "Martin Fowler", Year = 2002, Price = 14.2f }
//            };
//        }
//    }

//    //This code snippet demonstrates how to use lambda expressions to filter a
//    //list of books based on their publication year, and should be run in the main file.

//    //var books = new BookRepository().GetBooks();
//    //var after2009 = books.FindAll(b => b.Year > 2010);

//    //foreach (var book in after2009)
//    //{
//    //    Console.WriteLine($"{book.Title} by {book.Author} ({book.Year})");
//    //}
//}