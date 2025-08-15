class Program
{
    static void Main(string[] args)
    {
        // Create library
        Library library = new Library();
        
        // Create books
        Book book1 = new Book("Harry Potter", "Jk Rowling");
        Book book2 = new Book("Horrid Henry", "JR Rowling");
        
        // Create patron
        Patron john = new Patron("John");

        // Add to library
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddPatron(john);
        Console.WriteLine();
        
        // Show all books
        library.GetAllBooks();
        Console.WriteLine();
        
        // Borrow a book
        library.BorrowBook(john, book1);
        Console.WriteLine();
        
        // Show books again
        library.GetAllBooks();
        Console.WriteLine();
        
        // Return the book
        library.ReturnBook(john, book1);
        Console.WriteLine();
    
        library.GetAllBooks();
    }
}