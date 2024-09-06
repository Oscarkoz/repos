namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in the amount of packages of milk there is left");
            int number = int.Parse(Console.ReadLine());

            if (number < 10)
            {
                Console.WriteLine("Order 30 packages");
            }
            else if (number >= 10 && number <= 20)
            {
                Console.WriteLine("Order 20 packages");
            }
            else
            {
                Console.WriteLine("You don't have to order any milk");
            } 
        }
    }
}
