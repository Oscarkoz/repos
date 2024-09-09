namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Cylinder Calculator 1.0!");

            Console.Write("Ange cylinderns radie: ");
            string radiusAsString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsString);

            Console.Write("Ange cylinderns höjd ");
            string heightAsString = Console.ReadLine();
            double height = Convert.ToDouble(heightAsString);


            double piValue = Math.PI;
            double volume = piValue * radius * radius * height;

            Console.WriteLine($"Cylinderns volym är {volume} cm");
            double surfaceArea = 2 * piValue * radius * (piValue + height);
            
            Console.WriteLine($"Cylinder ytan är {surfaceArea} cm^2");

        }
    }
}
