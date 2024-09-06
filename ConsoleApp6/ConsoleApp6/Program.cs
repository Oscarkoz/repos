using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in your age");
            int age;

            // I could've also used the variable double for this exercise in order to be able to add decimals for kids that like to add their ".5"
            // But ages are usually "whole numbers", which means using int is just easier.
            if (int.TryParse(Console.ReadLine(), out age))
            {
                

                if (age < 18)
                {
                    Console.WriteLine("You are not an adult");
                }
                else if (age > 65)
                {
                    Console.WriteLine("You are an elderly");
                }
                else
                {
                    Console.WriteLine("You are an adult but not an elderly");
                }
            }
            else
            {
                Console.WriteLine("You did not put in any valid numbers, or might have used decimals");
            }
        }
    }
}
