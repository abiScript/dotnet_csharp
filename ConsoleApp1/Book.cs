namespace ConsoleApp1;

public class Book
{
    private string title;
    private string author;
    private int pages;

    public static int bookCount = 0; // Belongs to the class only, not the objects.

    public Book(string aTitle, string author, int pages)
    {
        Console.WriteLine("~ Creating book...");

        title = aTitle;
        this.author = author;
        this.pages = pages;

        bookCount++;
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

   public int GetBookCount()
   {
        return bookCount;
   }

   public static void DescribeBook(Book book)
   {
        Console.WriteLine("The " + book.Title + " book has " + book.Pages + " pages, authored by " + book.Author + ".");
   }
}
