namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Compound Operator
            string myNewString = "Oscar";
            myNewString += " William";
            myNewString += " Turell";
            Console.WriteLine(myNewString);

            // SubString()
            // Vad ger följande kod?
            string name = "Oscar Turell";
            string result = "";

            if (name.Substring(1, 2).Equals("sc"))
            {
                result = name.Remove(1, 2);
            }
            Console.WriteLine(result);

        }
    }
}
