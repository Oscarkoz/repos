namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringValue1 = "123";
            try
            { 
                    int intValue = Convert.ToInt32(stringValue1);
                    Console.WriteLine($"Konverterad till int: {intValue}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Fel vid konvertering: {ex.Message}");
            }

            string stringValue2 = "123.45";
            try
            {
                decimal decimalValue = Convert.ToDecimal(stringValue2);
                Console.WriteLine($"Konverterad till double: {decimalValue}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Fel vid konvertering till double: {ex.Message}");
            }

            try
            {
                string invalidString = "abc";
                int invalidInt = Convert.ToInt32(invalidString);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Fel vid konvertering till double: {ex.Message}");
            }
        }
    }
}
