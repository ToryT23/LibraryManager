using System;
using System.Collections.Generic;


namespace libraryExercise 
{

public class LibraryManager 
{
//Create a private field in the LibraryManager class called _books
//its type will be List<Book> , and you can set it equal to an empty List<Book>
   private List<Book> _books = new List<Book>();

    public string Name { get; set; }


 public LibraryManager(string name)
        {
            Name = name;
        }


//Write a method to add a book to an instance of LibraryManager's _books field, it should take a parameter of type Book

  public void AddingAbook(Book book)
        {   
        _books.Add(book);
        }

// Write a method for the LibraryManager class that displays the books in an instance of LibraryManagerusing the same format as #6 and #8
public void DisplayBooks ()
{
    foreach(Book book in _books) {
        Console.WriteLine($" The title of this book is {book.Title} and is written by {book.Author}");
    }
}

}
}
// Remove the code in the main method that you added in steps 6 and 8
// Create a new instance of the LibraryManager class at the beginning of the Main method, pass the constructor a name for your library.
// Write out "Welcome to the <Name> Library Management System!" to the console using your library instance.

// Use the method you wrote to add books to add all of the books you created in steps 5 and 7 to your
// instance of LibraryManagers _books
// Use the method you wrote to list all of the books to print all of the books out to the console.