public class Book
{
    public string Title;
    public string Author;
    public bool IsAvailable = true;
    public Book(string BookTitle, string BookAuthor)
    {
        Title = BookTitle;
        Author = BookAuthor;
    }
    public Book Borrow()
    {
        // Check if book is available first
        if (IsAvailable)
        {
            IsAvailable = false;  // set book to unaailable 
            return this; // retunr the instance
        }
        return null; // retunr nothhing
    }

    public bool ReturnBook()
    {
        // You set the availablitly to true
        if (IsAvailable == false)
        {
            IsAvailable = true;
            return true;
        }
        return false;
    }
}