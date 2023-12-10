namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int[,] numberGrid = {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            Console.WriteLine(numberGrid[2, 1]);

            Console.WriteLine();
        }
    }
}

// See https://aka.ms/new-console-template for more information on new style of template