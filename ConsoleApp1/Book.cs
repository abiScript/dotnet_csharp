namespace ConsoleApp1;

public class Book
{
    private string title;
    private string author;
    private int pages;

    public Book(string aTitle, string author, int pages)
    {
        Console.WriteLine("~ Creating book...");

        title = aTitle;
        this.author = author;
        this.pages = pages;
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

   public string Author
   {
        get { return author; }
   }

   public int Pages
   {
        get { return pages; }
   }
}
