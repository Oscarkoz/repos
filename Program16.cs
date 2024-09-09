namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number ");
            string whatTheUserTyped = Console.ReadLine();

            try
            {
                int ettNummer = Convert.ToInt32(whatTheUserTyped);
                Console.WriteLine($"Du skrev numret: {ettNummer}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Fealaktigt format. Skriv vänligen ett giltigt heltal annars funkar inte int.");
            }

            bool b = true;
            int i = Convert.ToInt32(b);
            Console.WriteLine($"Bool som int: {i}");

            double d = 3.4;
            float f = Convert.ToSingle(d);
            Console.WriteLine($"Double som float: {f}");
        }
    }
}
