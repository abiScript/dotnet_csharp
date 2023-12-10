namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine(GetPow(4, 3));

            Console.WriteLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }

    }
}

// See https://aka.ms/new-console-template for more information on new style of template