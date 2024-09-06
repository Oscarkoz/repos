using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in a number");
            int number = int.Parse(Console.ReadLine());

            if (number > 10)
            {
                Console.WriteLine("The number is larger than 10");
            }
            else if (number < 10)
            {
                Console.WriteLine("The number is smaller than 10");
            }
            else
            {
                Console.WriteLine("The number is 10");
            }
        }
    }
}
