using System;
using System.Globalization;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in your body temperature");
            double temperature = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (temperature > 39.5)
            {
                Console.WriteLine("You should contact a doctor.");
            }
            else if (temperature > 37.8)
            {
                Console.WriteLine("You have a fever.");
            }
            else
            {
                Console.WriteLine("You don't have a fever.");
            }
        }
    }
}
