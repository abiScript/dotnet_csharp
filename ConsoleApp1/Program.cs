namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.Write("Enter your name: ");
            string? userName = Console.ReadLine();

            Console.Write("Enter your age: ");
            string? userAge = Console.ReadLine();

            Console.WriteLine("Hello " + userName + ", you are " + userAge + ".");

            Console.WriteLine();
        }
    }
}

// See https://aka.ms/new-console-template for more information on new style of template