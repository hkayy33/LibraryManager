class Book
{
    private string Title;
    private string Author;
    private bool IsAvailable;
    public Book(string BookTitle, string BookAuthor, bool IsBookAvailable)
    {
        Title = BookTitle;
        Author = BookAuthor;
        IsAvailable = IsBookAvailable;
    }

    public void Borrow()
    {

    }

    public void ReturnBook()
    {
        
    }
}