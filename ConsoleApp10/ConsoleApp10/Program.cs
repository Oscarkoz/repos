namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how much money you got");

            double discount = double.Parse(Console.ReadLine());

            Console.WriteLine("Do you have any discounts? (yes/no)?");
            bool hasDiscount = Console.ReadLine().Trim().ToLower() == "true";

            if (discount >= 15 && discount <= 25)
            {
                if (hasDiscount)
                {
                    Console.WriteLine("You can buy a small hamburger and fries");
                }
                else
                {
                    Console.WriteLine("You can buy a small hamburger");
                }
            }
            else if (discount > 25 && discount < 50)
            {
                if (hasDiscount)
                {
                    Console.WriteLine("You can buy a large hamburger and fries.");
                }
                else
                {
                    Console.WriteLine("You can buy a large hamburger.");
                }
            }
            else if (discount > 60 || (discount >= 50 && discount <= 60 && hasDiscount))
            {
                Console.WriteLine("You can buy a meal with a drink");
            }
            else
            {
                Console.WriteLine("You do not have enough money for the options.");
            }

        }
    }
}
