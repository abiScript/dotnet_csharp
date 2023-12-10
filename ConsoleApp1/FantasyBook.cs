namespace ConsoleApp1;

public class FantasyBook : Book
{
    public static int fantasyBookCount = 0;
    
    public FantasyBook(string aTitle, string author, int pages) : base(aTitle, author, pages)
    {
        fantasyBookCount++;
    }

    public void SayHiFantasy()
    {
        Console.WriteLine("Hello! I'm Fantasy");
    }

    public override int GetBookCount()
    {
        return fantasyBookCount;
    }
}
