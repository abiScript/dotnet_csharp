namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            int[] luckyNumbers = [4, 8, 15, 17, 35, 48];

            luckyNumbers[4] = 900;
            
            Console.WriteLine(luckyNumbers[4]);

            string[] people = new string[5];

            people[0] = "Jim";
            people[1] = "Kelly";
            
            Console.WriteLine();
        }
    }
}

// See https://aka.ms/new-console-template for more information on new style of template