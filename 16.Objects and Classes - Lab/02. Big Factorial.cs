using System.ComponentModel;
using System.Numerics;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        BigInteger result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        Console.WriteLine(result);
    }
}