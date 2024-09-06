using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How old are you?");

            int ages = int.Parse(Console.ReadLine());

            if (ages <= 18 && ages > 0)
            {
                Console.WriteLine("You are a teenager/child");
            }

            else if (ages > 18 && ages < 65)
            {
                Console.WriteLine("You are an adult");
            }
            else if (ages >= 65)
            {
                Console.WriteLine("You are an elderly");
            }
            else
            {
                Console.WriteLine("You are not even born yet");
            }

            {
                string name = "Oscar";
                int age = 24;
                double height = 190;

                string presentation = ($"Hello mate, I'm {name}, I am {age} years old and {height} cm tall!");
                Console.WriteLine(presentation);
            }
        }
    }
}
