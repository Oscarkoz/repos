using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth");

            int birthyear;

            if (int.TryParse(Console.ReadLine(), out birthyear))
            {
                if (birthyear >= 1980 && birthyear < 1990)
                {
                    Console.WriteLine("You are born in the 80's");
                }
                else if (birthyear >= 1990 && birthyear < 2000)
                {
                    Console.WriteLine("You are born in the 90's");
                }
                else 
                {
                    Console.WriteLine("You are not born in the 90's or the 80's");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid year.");
            }
        }
    }
}
