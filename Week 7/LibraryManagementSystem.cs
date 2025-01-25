using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement
{
    // Authors Table
    public class Author
    {
        public int AuthorId { get; set; } // Unique ID for the author
        public string Name { get; set; } // Name of the author
    }

    // Books Table
    public class Book
    {
        public int BookId { get; set; } // Unique ID for the book
        public string Title { get; set; } // Title of the book
        public int AuthorId { get; set; } // ID of the author (foreign key from Authors table)
    }

    class Program
    {
        static void Main(string[] args)
        {
            // List of authors
            List<Author> authors = new List<Author>
            {
                new Author { AuthorId = 1, Name = "Orhan Pamuk" },
                new Author { AuthorId = 2, Name = "Elif Safak" },
                new Author { AuthorId = 3, Name = "Ahmet Ümit" }
            };

            // List of books
            List<Book> books = new List<Book>
            {
                new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
                new Book { BookId = 2, Title = "Istanbul", AuthorId = 1 },
                new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
                new Book { BookId = 4, Title = "Beyoglu Rapsodisi", AuthorId = 3 }
            };

            // LINQ query to join books and authors
            var query = from book in books
                        join author in authors on book.AuthorId equals author.AuthorId
                        select new { book.Title, author.Name };

            // Print results to the console
            Console.WriteLine("Book Titles and Authors:");
            foreach (var item in query)
            {
                Console.WriteLine($"Book: {item.Title}, Author: {item.Name}");
            }
        }
    }
}
