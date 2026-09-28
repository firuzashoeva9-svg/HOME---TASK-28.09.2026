public class Book : AbstractBook, IBorrowable
{
    public void Borrow()
    {
        Console.WriteLine($"The book '{Title}' has been borrowed.");
    }

    public void ReturnBook()
    {
        Console.WriteLine($"The book '{Title}' has been returned.");
    }
}