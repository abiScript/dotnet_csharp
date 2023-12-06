namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string? colour, pluralNoun, celebrity;

            Console.WriteLine();

            Console.Write("Enter a colour: ");
            colour = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Roses are " + colour);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
            
            Console.WriteLine();
        }
    }
}

// See https://aka.ms/new-console-template for more information on new style of template