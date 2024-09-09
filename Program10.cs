using System;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // För decimal, delning med noll orsakar ett undantag
            decimal numerator = 10.0m;
            decimal denominator = 0.0m;

            try
            {
                // Kontrollera nämnaren innan division
                if (denominator == 0.0m)
                {
                    throw new DivideByZeroException("Division med noll är inte tillåten för decimal.");
                }
                decimal result1 = numerator / denominator; // Detta ska inte köras
                Console.WriteLine($"result1: {result1}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Fel vid decimal-division: {ex.Message}");
            }

            // För float, delning med noll ger Infinity
            float numeratorFloat = 1.0f;
            float denominatorFloat = 0.0f;
            float result2 = numeratorFloat / denominatorFloat;
            Console.WriteLine($"result2: {result2}"); // Förväntat resultat: Infinity

            // För double, delning med noll ger Infinity
            double numeratorDouble = 1.0;
            double denominatorDouble = 0.0;
            double result3 = numeratorDouble / denominatorDouble;
            Console.WriteLine($"result3: {result3}"); // Förväntat resultat: Infinity

            // Utskrift av variabler
            Console.WriteLine($"Numerator: {numerator}, Denominator: {denominator}");
        }
    }
}
