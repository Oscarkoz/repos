namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short a = 32767;
            short b = 1;
            short sum = (short)(a + b);
            Console.WriteLine(sum);

            short min = short.MinValue;
            Console.WriteLine(min);
            
        }
    }
}
