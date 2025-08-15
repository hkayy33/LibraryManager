public class Library
{
    public List<Book> Books = [];
    public List<Patron> patrons = [];

    public void AddBook(Book book)
    {
        // add a book object to the list
    }
    public void RemoveBook(Book book)
    {
        
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