namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Book myBook = new("Potter",  "Rowling", 100);

        myBook.Title = "Hobbit";

        Console.WriteLine("The " + myBook.Title + " book has " + myBook.Pages + " pages, authored by " + myBook.Author + ".");
        
        Console.WriteLine(myBook.GetBookCount());

        Book myBook2 = new("Rings", "Tolkein", 2000);

        Console.WriteLine("The " + myBook2.Title + " book has " + myBook2.Pages + " pages, authored by " + myBook2.Author + ".");

        Console.WriteLine(Book.bookCount);

        Console.WriteLine();
    }
}


// See https://aka.ms/new-console-template for more information on new style of template