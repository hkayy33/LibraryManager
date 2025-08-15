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
        Console.WriteLine($"{book.Title} duplicate book");
        // assuming that there is only allowed to be one of each book
    }
    public void RemoveBook(Book book)
    {
         if (Books.Contains(book))
        {
            Books.Remove(book);
            Console.WriteLine($"{book.Title} has been Removed from the library system");
        }
        Console.WriteLine($"{book.Title} does not exist");
    }

    public void GetBookByAuthor(String Author)
    {
        

    }

    public void GetBookByTitle(string title)
    {

    }
    public void GetAllBooks()
    {

    }

    public void AddPatron(Patron patron)
    {
        if (!patrons.Contains(patron))
        {
            patrons.Add(patron);
            Console.WriteLine($"Successfully added {patron.Name}");
        }
        
    }
    public void RemovePatron(Patron patron)
    {
        if (patrons.Contains(patron))
        {
            patrons.Remove(patron);
            Console.WriteLine($"Successfully removed {patron.Name}");
        }

    }

    public void BorrowBook(Patron patron, Book book)
    {

    }
    public void ReturnBook(Patron patron, Book book)
    {
        
    }
    


}