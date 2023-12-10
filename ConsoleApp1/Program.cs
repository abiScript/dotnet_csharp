namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Book myBook = new()
        {
            title = "Potter",
            author = "Rowling",
            pages = 100
        };

        Console.WriteLine("The " + myBook.title + " book has " + myBook.pages + " pages, authored by " + myBook.author + ".");

        Book myBook2 = new()
        {
            title = "Rings",
            author = "Tolkein",
            pages = 2000
        };

        Console.WriteLine("The " + myBook2.title + " book has " + myBook2.pages + " pages, authored by " + myBook2.author + ".");

        Console.WriteLine();
    }
}


// See https://aka.ms/new-console-template for more information on new style of template