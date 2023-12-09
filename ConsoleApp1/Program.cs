namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            SayHi("Sally", 21);
            SayHi("Tim", 50);
            SayHi("Thanos", 10394);
        
            Console.WriteLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hi " + name + ", you are " + age);
        }
    }
}

// See https://aka.ms/new-console-template for more information on new style of template