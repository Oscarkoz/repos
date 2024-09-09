using System;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Decimal division med noll
            try
            {
                decimal numeratorDecimal = 10.0m;
                decimal denominatorDecimal = 0.0m;
                decimal resultDecimal = numeratorDecimal / denominatorDecimal; // Detta ska orsaka undantag
                Console.WriteLine($"Decimal result: {resultDecimal}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Fel vid decimal-division: {ex.Message}");
            }

            // Float division med noll
            float numeratorFloat = 1.0f;
            float denominatorFloat = 0.0f;
            float resultFloat = numeratorFloat / denominatorFloat;
            Console.WriteLine($"Float result: {resultFloat}"); // Förväntat: Infinity

            // Double division med noll
            double numeratorDouble = 1.0;
            double denominatorDouble = 0.0;
            double resultDouble = numeratorDouble / denominatorDouble;
            Console.WriteLine($"Double result: {resultDouble}"); // Förväntat: Infinity
        }
    }
}
