namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotiant = a / b;
            int remainder = a % b;

            int results = b * quotiant + remainder;
            Console.WriteLine($"{b} * {quotiant} + {remainder} = {results}");
        }
    }
}
