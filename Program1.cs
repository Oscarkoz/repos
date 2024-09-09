using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ange beloppet som ska växlas: ");
        int sum = int.Parse(Console.ReadLine());

        VäxlaPengar(sum);
    }

    static void VäxlaPengar(int sum)
    {
        int[] values = { 500, 100, 50, 20, 10, 5, 1 };
        int amount;

        foreach (int value in values)
        {
            amount = sum / value;
            sum %= value;

            if (amount > 0)
            {
                Console.WriteLine($"{amount} st {value}-lappar/mynt");
            }
        }
    }
}
