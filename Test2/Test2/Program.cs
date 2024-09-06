using System;
using System.ComponentModel.Design;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nedan visar jag hur man kan använda funktionen "switch" Vilket är en ersättning för att behöva ständigt skriva if-else satser.
            // Switch satsen består av olika delar, dessa är switch uttrycket, case satsen och default satsen. 
            // Switch uttrycket är vad som påbörjar en switch, det är en jämförelse som görs med ursprunget, i detta fall är det "day".
            // Varje case-sats representerar ett möjligt värde som switch uttrycket kan ha. Om värdena matchar, alltså i detta fall att det är dag 3, så exekveras kodblocket associerat med dag 3.
            // Default-satsen är det som händer om inget alternativ stämmer överens med switch-uttrykcet, alltså i detta fall om day var = 6. 
            // Default-satsen är också valfri, om man inte inkluderar den så händer istället ingenting, om värdena inte stämmer överens.
            int day = 6;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Weekday or non legitimate day");
                    break;    
            }
            
                {
                    int ages = 64;

                    if (ages <= 18 && ages > 0)
                    {
                        Console.WriteLine("You are a teenager/child");
                    }

                    else if (ages > 18 && ages < 65)
                    {
                        Console.WriteLine("You are an adult");
                    }
                    else if (ages >= 65)
                    {
                        Console.WriteLine("You are an elderly");
                    }
                    else
                    {
                        Console.WriteLine("You are not even born yet"); 
                    }
                }
    }
}
