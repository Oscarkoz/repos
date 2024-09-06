using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your category, adult, elderly or student");

            string category = Console.ReadLine().Trim().ToLower();
            // Trim används för att göra det möjligt att av misstag göra mellanslag
            // ToLower används för att kunna skriva saker i småbokstäver. Detta är för att undvika att man får programmet att strula genom att man skriver med olika storlekar på bokstäverna

            switch (category)
            {
                case "elderly":
                case "student":
                    Console.WriteLine("You're an elderly or student so the trip costs 20 crowns");
                    break;
                case "adult":
                    Console.WriteLine("You are an adult, therefore the trip costs 30 crowns");
                    break;
                default:
                    Console.WriteLine("You have entered an invalid category");
                    break;
            }
        }
    }
}
