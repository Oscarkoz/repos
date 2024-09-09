namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Length()
            string text = "Hello, World!";
            int length = text.Length;
            Console.WriteLine(length);

            // Replace()
            string text2 = "Hello, World!";
            string replacedText = text.Replace("Hello", "Hi");
            Console.WriteLine(replacedText);

            // Split()
            string text3 = "Hello, World!";
            string[] words = text.Split(',');
            Console.WriteLine(words[0]);
            Console.WriteLine(words[1]);

        }
    }
}
