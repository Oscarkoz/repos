namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base of the triangle: ");
            decimal basen = decimal.Parse(Console.ReadLine().Trim());

            Console.Write("Enter the height of the triangle: ");
            decimal height = decimal.Parse(Console.ReadLine().Trim());

            decimal area = (height * basen) / 2;
            Console.WriteLine($"The area of your triangle is {area}");
        }
    }
}
