namespace LambdaExpression
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }

    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Title = "C# in Depth", Author = "Jon Skeet", Year = 2019 },
                new Book { Title = "Pro ASP.NET Core", Author = "Adam Freeman", Year = 2020 },
                new Book { Title = "Clean Code", Author = "Robert C. Martin", Year = 2008 },
                new Book { Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Year = 1999 }
            };
        }
    }

    //This code snippet demonstrates how to use lambda expressions to filter a
    //list of books based on their publication year, and should be run in the main file.

    //var books = new BookRepository().GetBooks();
    //var after2009 = books.FindAll(b => b.Year > 2010);

    //foreach (var book in after2009)
    //{
    //    Console.WriteLine($"{book.Title} by {book.Author} ({book.Year})");
    //}
}