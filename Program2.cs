using System;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base of the triangle: ");
            float basen = float.Parse(Console.ReadLine().Trim());

            Console.Write("Enter the height of the triangle: ");
            float höjden = float.Parse(Console.ReadLine());

            float area = (basen * höjden) / 2;

            Console.WriteLine($"The area of the triangle is: {area}");
        }
    }
}
