namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in the amount of milk packages there is left");
            int number = int.Parse(Console.ReadLine());

            int numbers = 30;
            switch (numbers)
            {
                case 1:
                    Console.WriteLine("Order 10 packages");
                    break;
                case 2:
                    Console.WriteLine("Order 20 packages");
                    break;
                case 3:
                    Console.WriteLine("Order 30 packages");
                    break;
                default:
                    Console.WriteLine("You dont need to order any milk");
                    break;
            }
        }
    }
}
