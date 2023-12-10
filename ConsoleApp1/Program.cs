namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("Error found");
            }
            // finally
            // {
            // }

            Console.WriteLine();
        }
    }
}

// See https://aka.ms/new-console-template for more information on new style of template