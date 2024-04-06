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
        int n = int.Parse(Console.ReadLine());
        int startNumber = int.Parse(Console.ReadLine());

        int result = 0;

        for (int i = startNumber; i <= 10; i++)
        {
            result = n * i;
            Console.WriteLine($"{n} X {i} = {result}");
        }

        if (startNumber > 10)
        {
            result = n * startNumber;
            Console.WriteLine($"{n} X {startNumber} = {result}");
        }
    }
}