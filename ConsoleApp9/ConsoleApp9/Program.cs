namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter what country you live in.");

            string country = Console.ReadLine().Trim().ToLower();

            switch (country)
            {
                case "sweden":
                case "denmark":
                case "norway":
                case "finland":
                case "iceland":
                    Console.WriteLine("You live in scandinavia");
                    break;
                default:
                    Console.WriteLine("You do not live in scandinavia");
                    break;
            }
        }
    }
}
