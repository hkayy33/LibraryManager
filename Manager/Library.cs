public class Library
{
    public List<Book> Books = [];
    public List<Patron> patrons = [];

    public void AddBook(Book book)
    {
        if (!Books.Contains(book))
        {
            Books.Add(book);
            Console.WriteLine($"{book.Title} has been added to the library system");
        }
        else
        {
            Console.WriteLine($"{book.Title} duplicate book");
            // assuming that there is only allowed to be one of each book
        }
    }
    public void RemoveBook(Book book)
    {
        if (Books.Contains(book))
        {
            Books.Remove(book);
            Console.WriteLine($"{book.Title} has been Removed from the library system");
        }
        else
        {
            Console.WriteLine($"{book.Title} does not exist");
        }
    }

    public void GetBookByAuthor(String Author)
    {
        IEnumerable<Book> bookAuth =
            from b in Books
            where b.Author == Author
            select b;

        foreach (var books in bookAuth)
        {
            Console.WriteLine(books);
        }

    }

    public void GetBookByTitle(string title)
    {
        IEnumerable<Book> booksbytitles =
            from b in Books
            where b.Title == title
            select b;

        foreach (var books in booksbytitles)
        {
            Console.WriteLine(books);
        }
    }
    public void GetAllBooks()
    {
        IEnumerable<Book> allBooks =
            from b in Books
            select b;
        Console.WriteLine("___Books in the Library:___");
        string availablility = "Available";
        foreach (var books in allBooks)
        {
            if (!books.IsAvailable)
            {
                availablility = "Not-Available";
            }

            Console.WriteLine($"{books.Title}  [{availablility}]");
        }
    }

    public void AddPatron(Patron patron)
    {
        if (!patrons.Contains(patron))
        {
            patrons.Add(patron);
            Console.WriteLine($"Successfully added {patron.Name} as a patron");
        }
        else{
            Console.WriteLine("Unable to add patron");
        }

    }
    public void RemovePatron(Patron patron)
    {
        if (patrons.Contains(patron))
        {
            patrons.Remove(patron);
            Console.WriteLine($"Successfully removed {patron.Name}");
        }
         else{
            Console.WriteLine("Unable to remove patron");
        }

    }

    public void BorrowBook(Patron patron, Book book)
    {
        // Check if the patron exists in the library system
        if (!patrons.Contains(patron))
        {
            Console.WriteLine($"Patron {patron.Name} is not registered in the library system.");
            return;
        }
        // Check if the book exists in the library system
        if (!Books.Contains(book))
        {
            Console.WriteLine($"Book '{book.Title}' is not available in this library.");
            return;
        }
        patron.Borrow(book);
    }
    public void ReturnBook(Patron patron, Book book)
    {

        if (!patrons.Contains(patron))
        {
            Console.WriteLine($"Patron {patron.Name} is not registered in the library system.");
            return;
        }
        if (!Books.Contains(book))
        {
            Console.WriteLine($"Book '{book.Title}' does not belong to this library.");
            return;
        }
        patron.ReturnBook(book);
    }



}