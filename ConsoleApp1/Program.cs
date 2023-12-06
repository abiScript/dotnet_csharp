namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Dude";
            int characterAge = 25;

            Console.WriteLine("");
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Fresh";

            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();
        }
    }
}

// See https://aka.ms/new-console-template for more information on new style of template