using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;


internal class Program
{
    private static void Main(string[] args)
    {
        decimal numbers = decimal.Parse(Console.ReadLine());

        if (Math.Abs(numbers) % 2 == 0)
        {
            Console.WriteLine($"The number is: {Math.Abs(numbers)}");
        }

        while (Math.Abs(numbers) % 2 == 1)
        {

            Console.WriteLine($"Please write an even number.");

            numbers = decimal.Parse(Console.ReadLine());

            if (Math.Abs(numbers) % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(numbers)}");
                break;
            }
        }



    }
}