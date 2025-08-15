public class Patron
{
    public string Name;
    public List<Book> BorrowedBooks = [];
    public Patron(string name)
    {
        Name = name;
    }

     public void Borrow(Book book)
    {
        if (book.IsAvailable == true)
        {
            Book borrowedBook = book.Borrow(); 
            if (borrowedBook != null) 
            {
                BorrowedBooks.Add(borrowedBook);
                Console.WriteLine($"You have borrowed {book.Title}");
                return; 
            }
        }
        Console.WriteLine($"{book.Title} is unavailable.");
    }

    public void ReturnBook(Book book)
    {
        
        if (BorrowedBooks.Contains(book) && book.IsAvailable == false)
        {
            bool returned = book.ReturnBook(); 
            if (returned)
            {
                BorrowedBooks.Remove(book);
                Console.WriteLine($"{book.Title} has successfully been returned");
                return; 
            }
        }
        Console.WriteLine($"{book.Title} cannot be returned.");
    }


}