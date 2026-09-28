public abstract class AbstractBook : IReadable
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;

    public void SetTitle(string title)
    {
        Title = title;
    }

    public string GetTitle()
    {
        return Title;
    }

    public void SetAuthor(string author)
    {
        Author = author;
    }

    public string GetAuthor()
    {
        return Author;
    }
    public virtual void Read()
    {
        Console.WriteLine($"Reading {Title} by {Author}");
    }
}