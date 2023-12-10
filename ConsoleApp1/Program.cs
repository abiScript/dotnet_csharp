namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Book myBook = new("Potter",  "Rowling", 100);

        myBook.Title = "Hobbit";

        Book.DescribeBook(myBook);

        Console.WriteLine(myBook.GetBookCount());

        Book myBook2 = new("Rings", "Tolkein", 2000);

        Book.DescribeBook(myBook2);
        
        Console.WriteLine(Book.bookCount);

        FantasyBook fantasyBook = new("Fanta", "Me", 150);

        fantasyBook.SayHiFantasy();
        Book.DescribeBook(fantasyBook);

        Console.WriteLine(fantasyBook.GetBookCount());

        Console.WriteLine();
    }
}


// See https://aka.ms/new-console-template for more information on new style of template