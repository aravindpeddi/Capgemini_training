//using System.Threading;

//**Constructor Overloading in a Library System**

//Implement a `Book` class with three different constructors: (1) Default constructor, (2) Constructor with `Title` and `Author`, (3) Constructor with `Title`, `Author`, and `ISBN`. Ensure each constructor initializes properties correctly.

using System;
namespace c__Assignment
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            ISBN = "000000";
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = "000000";
        }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }

    //public class Program
    //{
    //    static void Main()
    //    {
    //        Book defaultBook = new Book();
    //        Console.WriteLine($"Title: {defaultBook.Title}, Author: {defaultBook.Author}, ISBN: {defaultBook.ISBN}");

    //        Book bookWithTitleAndAuthor = new Book("1994", "Asha");
    //        Console.WriteLine($"Title: {bookWithTitleAndAuthor.Title}, Author: {bookWithTitleAndAuthor.Author}, ISBN: {bookWithTitleAndAuthor.ISBN}");

    //        Book completeBook = new Book("1994", "Asha", "123456");
    //        Console.WriteLine($"Title: {completeBook.Title}, Author: {completeBook.Author}, ISBN: {completeBook.ISBN}");
    //    }
    //}
}