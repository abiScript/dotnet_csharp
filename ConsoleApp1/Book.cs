namespace ConsoleApp1;

public class Book
{
    public string? title;
    public string? author;
    public int pages;

    public Book()
    {

    }

    public Book(string aTitle, string author, int pages)
    {
        Console.WriteLine("~ Creating book...");

        title = aTitle;
        this.author = author;
        this.pages = pages;
    }
}
