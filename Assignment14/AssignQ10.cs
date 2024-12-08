//using System;
//using System.Collections.Generic;

//class Library
//{   
//    private List<string> books;
//    public Library()
//    {
//        books = new List<string>();
//    }
//    public void AddBook(string book)
//    {
//        books.Add(book);
//        Console.WriteLine($"Book '{book}' added to the library.");
//    }
//    public void RemoveBook(string book)
//    {
//        if (books.Contains(book))
//        {
//            books.Remove(book);
//            Console.WriteLine($"Book '{book}' removed from the library.");
//        }
//        else
//        {
//            Console.WriteLine($"Book '{book}' not found in the library.");
//        }
//    }
//    public void DisplayBooks()
//    {
//        if (books.Count == 0)
//        {
//            Console.WriteLine("No books in the library.");
//        }
//        else
//        {
//            Console.WriteLine("Books in the library:");
//            foreach (string book in books)
//            {
//                Console.WriteLine(book);
//            }
//        }
//        Console.ReadLine();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Library library = new Library();
//        library.AddBook("Marathi Story");
//        library.AddBook("1984");
//        library.AddBook("Hindi Story");

//        library.DisplayBooks();
//        library.RemoveBook("1984");
//        library.DisplayBooks();
//        library.RemoveBook("Hindi Story");
//        library.DisplayBooks();
//    }
//}
