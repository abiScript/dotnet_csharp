namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine(Cube(3));

            Console.WriteLine();
        }

        static int Cube(int number)
        {
            int result = number * number * number;
            return result;
        }
    }
}

// See https://aka.ms/new-console-template for more information on new style of template