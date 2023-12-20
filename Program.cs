using Library_Management_System;
using System;
using System.Collections.Generic;

namespace Library_Management_System
{   class Program
    {       static void Main(string[] args)
        {
            // Initialize the library catalog
            var libraryCatalog = new LibraryCatalog();
            // Create some sample books
            var novel1 = new Novel { Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 };
            var textbook1 = new Textbook { Title = "Introduction to Algorithms", Author = "Cormen, Leiserson, Rivest, Stein", YearPublished = 2009, Subject = "Computer Science" };
            // Add books to the catalog
            libraryCatalog.AddItem(novel1);
            libraryCatalog.AddItem(textbook1);
            // List all items in the catalog
            ConsoleHelper.WriteLineWithColor("Library Catalog:", ConsoleColor.Yellow);
            libraryCatalog.ListItems();
            // Search for a book by title
            Console.WriteLine("\nEnter the title of the book to search:");
            string searchTitle = Console.ReadLine();
            var foundBook = libraryCatalog.GetItemByTitle(searchTitle);
            if (foundBook != null)
            {
                ConsoleHelper.WriteLineWithColor($"Found: {foundBook.GetBookType()}: {foundBook.Title} by {foundBook.Author} ({foundBook.YearPublished})", ConsoleColor.Green);
                // Checkout the book
                var checkoutService = new BookCheckoutService();
                checkoutService.CheckOutBook(foundBook);
                // Remove the book from the catalog
                libraryCatalog.RemoveItem(foundBook);
            }
            else
            {
                ConsoleHelper.WriteLineWithColor("Book not found in the catalog.", ConsoleColor.Red);
            }

            Console.ReadKey();   }   }   }
