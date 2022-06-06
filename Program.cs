using System;
using System.Collections.Generic;

namespace libraryExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a new instance of the LibraryManager class at the beginning of the Main method, pass the constructor a name for your library.
            LibraryManager managerLib = new LibraryManager("Holy Books");




            //Write out "Welcome to the <Name> Library Management System!" to the console using your library instance.
            Console.WriteLine($"Welcome to the {managerLib.Name} Library Management System!");


            // In the main method, create an instance of
            // the Book class,   and save its value as a variable
            //another example of an instance could be 
            // List<Book> librayBook = new List<Book>();
            
            Book helloWorld = new Book()
            {
                Title = "Hello You",
                Author = "ToJo",
                PublishDate = new DateTime(2022, 5, 31),
                Genre = "Novel"
            };
            //7 Create some more books and store them in a List
            Book newPractice = new Book()
            {
                Title = "Nothing But you",
                Author = "Con FU",
                PublishDate = new DateTime(2022, 03, 13),
                Genre = "Fiction"
            };
            Book anotherOne = new Book()
            {
                Title = "I finally got it",
                Author = "Shirley",
                PublishDate = new DateTime(2021, 02, 14),
                Genre = "Romance"
            };
           
            
            // In the main method, create an instance of
            // the Book class,   and save its value as a variable
        var listOfBooks = new List<Book>() { helloWorld, newPractice, anotherOne };

// Iterate over that list of books, and print the title and author to the
// Console in the loop in the same format as in 6.
             foreach (Book book in listOfBooks)
            {
        // use the instance created above
        // and the method to add each book into the collection
                managerLib.AddingAbook(book);
            }
            // this method allows the name of the books to be displayed
            managerLib.DisplayBooks();



            //     foreach( Book book in librayBook){
            //    System.Console.WriteLine($"The title of the book is {book.Title} by {book.Author}");

            //     }


        }
    }
}
