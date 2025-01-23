using System;

public class Book
{
    // Properties of the Book class
    public string BookTitle { get; set; }
    public string AuthorFirstName { get; set; }
    public string AuthorLastName { get; set; }
    public int PageCount { get; set; }
    public string Publisher { get; set; }
    public DateTime RegistrationDate { get; set; }

    // Default constructor (constructor without parameters)
    public Book()
    {
        RegistrationDate = DateTime.Now; // The registration date is set to the current time when the object is created
    }

    // Parameterized constructor (constructor with parameters to set book details)
    public Book(string bookTitle, string authorFirstName, string authorLastName, int pageCount, string publisher)
    {
        BookTitle = bookTitle;
        AuthorFirstName = authorFirstName;
        AuthorLastName = authorLastName;
        PageCount = pageCount;
        Publisher = publisher;
        RegistrationDate = DateTime.Now; // The registration date is set to the current time when the object is created
    }

    // Override ToString() method to display the book's information
    public override string ToString()
    {
        return $"{BookTitle} - {AuthorFirstName} {AuthorLastName}, {PageCount} pages, {Publisher} publisher, Registration Date: {RegistrationDate}";
    }
}

class Program
{
    static void Main()
    {
        // Creating a book object using the parameterized constructor (Constructor 2)
        Book book1 = new Book("Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
        Console.WriteLine(book1);

        // Creating a book object using the default constructor (Constructor 1)
        Book book2 = new Book();
        Console.WriteLine(book2);
    }
}
